using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CNPM_FINAL.DAL
{
    public class TaskProgressDAL : BaseDAL
    {
        private readonly string JOIN_TABLES_DETAIL = @"
            SELECT
                tg.id,
                u.full_name,
                u.user_code,
                c.contract_code,
                tg.task_name,
                tg.start_date,
                tg.end_date,
                tg.status
            FROM task_progress tg
            JOIN contracts c ON tg.contract_id = c.id
            JOIN users u ON tg.assigned_to = u.id
        ";

        private readonly string JOIN_TABLES = @"
            SELECT 
                c.contract_code,
	            c.contract_name,
	            c.signed_date,
	            c.expiration_date,
	            c.organization_name,
                ROUND(
                    COALESCE(
                        CAST(SUM(CASE WHEN tg.status = 'Completed' THEN 1 ELSE 0 END) AS FLOAT) 
                        / NULLIF(COUNT(CASE WHEN tg.status != 'Canceled' THEN 1 END), 0) * 100, 
                        0
                    ), 
                    2
                ) AS completion_percentage
            FROM 
                task_progress tg
            JOIN 
                contracts c ON tg.contract_id = c.id
        ";

        private readonly string GROUP_BY = @"
            GROUP BY 
                c.contract_code,
                c.contract_name,
                c.signed_date,
                c.expiration_date,
                c.organization_name
        ";


        public void Insert(Dictionary<string, object> parameters)
        {
            string query = @"
            INSERT INTO task_progress 
                (contract_id, task_name, assigned_to, start_date, end_date, status)
            VALUES
                (@contractId, @taskName, @assignedTo, @startDate, @endDate, @status)
            ";
            this.ExecuteNonQuery(query, parameters);
        }

        public void Update(Dictionary<string, object> parameters)
        {
            string query = @"
            UPDATE task_progress
            SET
                task_name = @taskName,
                assigned_to = @assignedTo,
                start_date = @startDate,
                end_date = @endDate,
                status = @status
            WHERE id = @id";
            this.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM task_progress WHERE id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            this.ExecuteNonQuery(query, parameters);
        }

        public bool ExistByContractCode(Dictionary<string, object> parameters = null)
        {
            List<TaskProgressDTO> tasks = new List<TaskProgressDTO>();
            string query = $"{JOIN_TABLES_DETAIL} WHERE c.contract_code = @contractCode";

            var data = this.ExecuteQuery(query, parameters);
            return data.Rows.Count > 0;
        }

        public List<TaskProgressDTO> GetAll(Dictionary<string, object> parameters, bool hasStartDate, bool hasEndDate)
        {
            List<TaskProgressDTO> tasks = new List<TaskProgressDTO>();
            string query = $"{JOIN_TABLES} WHERE 1 = 1";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (c.contract_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR c.contract_name COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword)";
            }

            if (parameters.ContainsKey("@userId"))
            {
                query += " AND (tg.assigned_to = @userId OR c.user_id = @userId)";
            }

            if(hasStartDate)
            {
                query += " AND (c.signed_date BETWEEN @dateFrom AND @dateTo)";
            }

            if (hasEndDate)
            {
                query += " AND (c.expiration_date BETWEEN @dateFrom AND @dateTo)";
            }

            query += GROUP_BY;

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                tasks.Add(mapToDto(row));
            }

            return tasks;
        }

        public List<TaskProgressDTO> GetAllDetail(Dictionary<string, object> parameters, bool hasStartDate, bool hasEndDate)
        {
            List<TaskProgressDTO> tasks = new List<TaskProgressDTO>();
            string query = $"{JOIN_TABLES_DETAIL} WHERE c.contract_code = @contractCode";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND tg.task_name COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword";
            }

            if (parameters.ContainsKey("@userId"))
            {
                query += " AND (tg.assigned_to = @userId OR c.user_id = @userId)";
            }

            if (hasStartDate)
            {
                query += " AND (tg.start_date BETWEEN @dateFrom AND @dateTo)";
            }

            if (hasEndDate)
            {
                query += " AND (tg.end_date BETWEEN @dateFrom AND @dateTo)";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                tasks.Add(mapToDto(row, true));
            }

            return tasks;
        }

        public TaskProgressDTO GetById(int id)
        {
            string query = $"{JOIN_TABLES_DETAIL} WHERE tg.id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };

            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count == 0)
            {
                return null;
            }
            return mapToDto(data.Rows[0], true);
        }

        private TaskProgressDTO mapToDto(DataRow dataRow, bool isDetail = false)
        {
            var task = new TaskProgressDTO
            {
                contractCode = dataRow["contract_code"].ToString(),
            };

            if (isDetail)
            {
                task.id = Convert.ToInt32(dataRow["id"]);
                task.taskName = dataRow["task_name"].ToString();
                task.assignedTo = dataRow["user_code"].ToString();
                task.assignedToName = dataRow["full_name"].ToString();
                task.startDate = dataRow["start_date"] != DBNull.Value ?
                        Convert.ToDateTime(dataRow["start_date"]) : DateTime.MinValue;
                task.endDate = dataRow["end_date"] != DBNull.Value ?
                        Convert.ToDateTime(dataRow["end_date"]) : DateTime.MinValue;
                task.status = dataRow["status"].ToString();
            }
            else
            {
                task.signedDate = dataRow["signed_date"] != DBNull.Value ?
                    Convert.ToDateTime(dataRow["signed_date"]) : DateTime.MinValue;
                task.expirationDate = dataRow["expiration_date"] != DBNull.Value ?
                    Convert.ToDateTime(dataRow["expiration_date"]) : DateTime.MinValue;
                task.contractOrganization = dataRow["organization_name"].ToString();
                task.percentage = dataRow["completion_percentage"] != DBNull.Value ?
                    Convert.ToDouble(dataRow["completion_percentage"]) : 0;
                task.contractName = dataRow["contract_name"].ToString();
            }

            return task;
        }
    }
}
