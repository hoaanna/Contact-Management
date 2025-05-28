using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.GUI.SubItem.Commission;
using DocumentFormat.OpenXml.Packaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Support
{
    public partial class ChatbotGUI : Form
    {
        private const string ChatHistoryFilePath = "chat_history.json";
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public ChatbotGUI()
        {
            InitializeComponent();
            ShowChatHistory();

            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.CHATBOT_GUI, typeof(ChatbotGUI).Assembly);

            btnDel.Text = GetLocalizedString("delete");
            lbNewMessage.Text = GetLocalizedString("newMessage");
        }

        private string GetLocalizedString(string key)
        {
            return resourceManager.GetString(key, cultureInfo);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string contractText = textBox.Text;

            if (string.IsNullOrWhiteSpace(contractText) || contractText == "Nhập nội dung hợp đồng tại đây")
            {
                MessageBox.Show("Vui lòng nhập nội dung hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox.Text = "";
            textBoxResponse.Text = "Đang xử lý, vui lòng chờ...";
            btnSend.Enabled = false;

            string summary = await SummarizeUsingGoogleAIStudio(contractText);

            textBoxResponse.Text = summary;
            btnSend.Enabled = true;
        }

        private void history_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Lấy vị trí dòng được click
                int index = textBoxHistory.GetCharIndexFromPosition(e.Location);
                string clickedLine = GetLineAtPosition(textBoxHistory.Text, index).Trim();
                // Tách timestamp từ dòng được click
                if (clickedLine.Length >= 25) // Đảm bảo dòng đủ dài
                {
                    string timestampPart = clickedLine.Substring(6).Trim(); // Lấy phần timestamp từ dòng
                    timestampPart = NormalizeTimestamp(timestampPart); // Chuẩn hóa timestamp

                    // Kiểm tra timestamp với nhiều định dạng
                    string[] possibleFormats = { "yyyy-MM-dd HH:mm:ss", "dd-MM-yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };
                    if (DateTime.TryParseExact(timestampPart, possibleFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime clickedTime))
                    {
                        // Tìm lịch sử trong JSON
                        var chatHistory = LoadChatHistory();
                        var matchingEntry = chatHistory.FirstOrDefault(entry => entry.timestamp.ToString("yyyy-MM-dd HH:mm:ss") == clickedTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        if (matchingEntry != null)
                        {
                            textBox.Text = matchingEntry.userInput;
                            textBoxResponse.Text = matchingEntry.chatbotResponse;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lịch sử chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết lịch sử: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBoxResponse.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Documents|*.docx|All Files|*.*";
                openFileDialog.Title = "Chọn file Word";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string fileContent = ReadDocxFile(filePath);
                        if (!string.IsNullOrWhiteSpace(fileContent))
                        {
                            textBox.Text = fileContent;
                        }
                        else
                        {
                            MessageBox.Show("Tệp không chứa nội dung hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ lịch sử chat?",
                "Xác nhận xóa lịch sử",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(ChatHistoryFilePath))
                    {
                        File.Delete(ChatHistoryFilePath);

                        textBoxHistory.Clear();
                        textBoxHistory.Text = "Không có lịch sử nào.";
                        MessageBox.Show("Lịch sử chat đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tệp lịch sử chat để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa lịch sử: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ReadDocxFile(string filePath)
        {
            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
                {
                    var body = wordDoc.MainDocumentPart.Document.Body;

                    if (body == null || string.IsNullOrWhiteSpace(body.InnerText))
                    {
                        throw new Exception("File không chứa nội dung văn bản.");
                    }

                    return body.InnerText;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Không thể đọc file .docx: {ex.Message}");
            }
        }
        private string DetectLanguage(string text)
        {
            if (text.Any(c => "áàảãạâấầẩẫậăắằẳẵặêếềểễệoôơóòỏõọổồốỗộởỡớờợuúùủũụưứựửừữ".Contains(c)))
            {
                return "vi";
            }
            else if (text.All(c => c < 128))
            {
                return "en";
            }
            return "unknown";
        }
        private async Task<string> SummarizeUsingGoogleAIStudio(string text)
        {
            string apiKey = "AIzaSyDVr3zTwkNxZpqpGKNDaXm6HDiVh9Kb4UU";
            string apiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                var language = DetectLanguage(text);
                string languageName = language == "vi" ? "tiếng Việt" : "English";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new
                                {
                                    text = $"Hãy tóm tắt nội dung hợp đồng và liệt kê các điểm đáng ngờ bằng {languageName}. Nội dung hợp đồng: {text}"
                                }
                            }
                        }
                    }
                };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Parse JSON và trả về đoạn text tóm tắt
                        dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                        string summary = jsonResponse.candidates[0]?.content?.parts[0]?.text;
                        return summary ?? "Không tìm thấy tóm tắt hợp đồng.";
                    }
                    else
                    {
                        return $"Hệ thống ChatBot đang quá tải, vui lòng thử lại sau ít phút...";
                    }
                }
                catch (Exception ex)
                {
                    return $"Lỗi không mong đợi: {ex.Message}";
                }
            }
        }
        private void SaveChatHistory(ChatHistoryEntryDTO chatEntry)
        {
            List<ChatHistoryEntryDTO> chatHistory = LoadChatHistory();

            chatHistory.Add(chatEntry);
            try
            {
                string json = JsonConvert.SerializeObject(chatHistory, Formatting.Indented);
                File.WriteAllText(ChatHistoryFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu lịch sử chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<ChatHistoryEntryDTO> LoadChatHistory()
        {
            try
            {
                if (File.Exists(ChatHistoryFilePath))
                {
                    string json = File.ReadAllText(ChatHistoryFilePath);
                    return JsonConvert.DeserializeObject<List<ChatHistoryEntryDTO>>(json) ?? new List<ChatHistoryEntryDTO>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch sử: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<ChatHistoryEntryDTO>();
        }
        private void ShowChatHistory()
        {
            try
            {
                var chatHistory = LoadChatHistory();
                textBoxHistory.Clear();

                if (chatHistory.Any())
                {
                    foreach (var entry in chatHistory)
                    {
                        string title = $"Chat - {entry.timestamp:yyyy-MM-dd HH:mm:ss}\n{entry.chatbotResponse.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()}";
                        textBoxHistory.AppendText($"{title}\n\n");
                    }
                }
                else
                {
                    textBoxHistory.Text = "Không có lịch sử nào.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị lịch sử chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetLineAtPosition(string text, int index)
        {
            if (string.IsNullOrEmpty(text) || index < 0 || index >= text.Length)
                return string.Empty;

            int start = text.LastIndexOf('\n', index);
            start = (start == -1) ? 0 : start + 1;

            int end = text.IndexOf('\n', index);
            end = (end == -1) ? text.Length : end;

            if (start > end)
                return string.Empty;

            return text.Substring(start, end - start).Trim();
        }
        private string NormalizeTimestamp(string rawTimestamp)
        {
            try
            {
                string[] parts = rawTimestamp.Split(' ');
                string datePart = parts[0];
                string timePart = parts[1];

                string[] timeComponents = timePart.Split(':');
                string normalizedTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
                    int.Parse(timeComponents[0]),
                    int.Parse(timeComponents[1]),
                    timeComponents.Length > 2 ? int.Parse(timeComponents[2]) : 0
                );

                return $"{datePart} {normalizedTime}";
            }
            catch
            {
                return rawTimestamp;
            }
        }
        private void lbHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxResponse.Text))
            {
                MessageBox.Show("Đây là trang mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChatHistoryEntryDTO chatEntry = new ChatHistoryEntryDTO
            {
                timestamp = DateTime.Now,
                userInput = textBox.Text,
                chatbotResponse = textBoxResponse.Text
            };

            SaveChatHistory(chatEntry);

            if (textBoxHistory.Text.Contains("Không có lịch sử nào."))
            {
                textBoxHistory.Clear();
            }

            string title = $"Chat - {chatEntry.timestamp:yyyy-MM-dd HH:mm:ss}";
            textBoxHistory.AppendText($"{title}\n");
            textBox.Clear();
            textBoxResponse.Clear();
            ShowChatHistory();
        }
    }
}
