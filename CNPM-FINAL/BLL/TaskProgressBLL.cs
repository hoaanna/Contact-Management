using CNPM_FINAL.Context;
using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;

namespace CNPM_FINAL.BLL
{
    public class TaskProgressBLL
    {
        private readonly TaskProgressDAL taskProgressDAL  = new TaskProgressDAL();
        private readonly ContractDAL contractDAL = new ContractDAL();
        private readonly UserDAL userDAL = new UserDAL();

        public void Insert(TaskProgressDTO task)
        {
            var contract = contractDAL.GetOneByCode(task.contractCode);
            if (contract == null)
            {
                var message = SettingContext.Language == "vi" ?
                    "Hợp đồng không tồn tại hoặc đã bị xóa" : "Contract does not exist or deleted";
                throw new BuisinessException(message);
            }
            var parameters = new Dictionary<string, object>
            {
                { "@contractId", contract.id },
                { "@taskName", task.taskName },
                { "@assignedTo", UserContext.GetUserId() },
                { "@startDate", task.startDate },
                { "@endDate", task.endDate },
                { "@status", task.status }
            };

            taskProgressDAL.Insert(parameters);
        }

        public void Update(TaskProgressDTO task)
        {
            var user = userDAL.GetOneByUserCode(task.assignedTo);
            if(user == null)
            {
                var message = SettingContext.Language == "vi" ?
                    "Người dùng không tồn tại hoặc đã bị xóa" : "User does not exist or deleted";
                throw new BuisinessException(message);
            }

            var parameters = new Dictionary<string, object>
            {
                { "@id", task.id },
                { "@taskName", task.taskName },
                { "@assignedTo", user.id },
                { "@startDate", task.startDate },
                { "@endDate", task.endDate },
                { "@status", task.status }
            };
            taskProgressDAL.Update(parameters);
        }

        public void Delete(int id) => taskProgressDAL.Delete(id);

        public List<TaskProgressDTO> GetAll(string keyword, DateTime dateFrom, DateTime dateTo, bool hasStartDate, bool hasEndDate)
        {
            var parameters = new Dictionary<string, object> {
                { "@keyword", keyword }
            };

            if (hasEndDate || hasStartDate)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }

            if (UserContext.GetRoleName() == "Sale" || UserContext.GetRoleName() == "Accountant")
            {
                parameters.Add("@userId", UserContext.GetUserId());
            }

            return taskProgressDAL.GetAll(parameters, hasStartDate, hasEndDate);
        }

        public List<TaskProgressDTO> GetAllDetail(string keyword, string contractCode, DateTime dateFrom, DateTime dateTo, bool hasStartDate, bool hasEndDate)
        {
            var parameters = new Dictionary<string, object> {
                { "@keyword", keyword },
                { "@contractCode", contractCode }
            };

            if (hasEndDate || hasStartDate)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }

            if (UserContext.GetRoleName() == "Sale" || UserContext.GetRoleName() == "Accountant")
            {
                parameters.Add("@userId", UserContext.GetUserId());
            }

            return taskProgressDAL.GetAllDetail(parameters, hasStartDate, hasEndDate);
        }

        public TaskProgressDTO GetById(int id)
        {
            var task = taskProgressDAL.GetById(id);
            if(task == null)
            {
                var message = SettingContext.Language == "vi" ? 
                    "Công việc không tồn tại hoặc đã bị xóa" : "Task does not exist or deleted";
                throw new BuisinessException(message);
            }

            return task;
        }
    }
}
