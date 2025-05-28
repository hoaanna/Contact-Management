using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using CNPM_FINAL.Context;
using Font = iTextSharp.text.Font;

namespace CNPM_FINAL.BLL
{
    public class FileBLL
    {
        public void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath, List<int> excludedColumns = null)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                HashSet<int> excludedColumnSet = excludedColumns != null ? new HashSet<int>(excludedColumns) : new HashSet<int>();

                int colIndex = 1;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (!excludedColumnSet.Contains(i))
                    {
                        worksheet.Cells[1, colIndex].Value = dataGridView.Columns[i].HeaderText;
                        worksheet.Cells[1, colIndex].Style.Font.Bold = true;
                        worksheet.Cells[1, colIndex].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, colIndex].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                        colIndex++;
                    }
                }

                int rowIndex = 2;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        colIndex = 1;
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            if (!excludedColumnSet.Contains(i))
                            {
                                worksheet.Cells[rowIndex, colIndex].Value = row.Cells[i].Value?.ToString();
                                colIndex++;
                            }
                        }
                        rowIndex++;
                    }
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                try
                {
                    var file = new FileInfo(filePath);
                    package.SaveAs(file);
                    string message = SettingContext.Language == "en" ? "Excel file exported successfully! File saved at" : "Xuất file Excel thành công! File được lưu tại";
                    MessageBox.Show($"{message} {filePath}", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    string message = SettingContext.Language == "en" ? "Error saving Excel file" : "Lỗi khi lưu file Excel";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath, List<int> excludedColumns = null)
        {
            HashSet<int> excludedColumnSet = excludedColumns != null ? new HashSet<int>(excludedColumns) : new HashSet<int>();

            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 10, Font.NORMAL);

                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                int columnCount = dataGridView.Columns.Count - excludedColumnSet.Count;
                PdfPTable table = new PdfPTable(columnCount)
                {
                    WidthPercentage = 100
                };

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (!excludedColumnSet.Contains(column.Index))
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, font))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(headerCell);
                    }
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            if (!excludedColumnSet.Contains(i))
                            {
                                string cellValue = row.Cells[i].Value?.ToString() ?? string.Empty;
                                PdfPCell dataCell = new PdfPCell(new Phrase(cellValue, font))
                                {
                                    HorizontalAlignment = Element.ALIGN_LEFT
                                };
                                table.AddCell(dataCell);
                            }
                        }
                    }
                }

                document.Add(table);
                document.Close();
                string message = SettingContext.Language == "en" ? "PDF file exported successfully! File saved at" : "Xuất file PDF thành công! File được lưu tại";
                MessageBox.Show($"{message} {filePath}", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                string message = SettingContext.Language == "en" ? "Error saving PDF file" : "Lỗi khi lưu file PDF";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
