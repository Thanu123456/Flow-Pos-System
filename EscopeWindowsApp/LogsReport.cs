using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class LogsReport : Form
    {
        private readonly string _connectionString =
            "server=localhost;database=pos_system;uid=root;pwd=7777;";

        // Instantiating up front means you never hit an NRE on logsTable.
        private DataTable _logsTable = new DataTable();
        private DateTime? _selectedDate = null;

        public LogsReport()
        {
            InitializeComponent();

            // Wire up events in case they're not hooked in the designer:
            this.Load += LogsReport_Load;
            logsSearchText.TextChanged += LogsSearchText_TextChanged;
            logsReportFilterBtn.Click += LogsReportFilterBtn_Click;
            selectLogDateTime.ValueChanged += SelectLogDateTime_ValueChanged;
        }

        private void LogsReport_Load(object sender, EventArgs e)
        {
            // Define columns only once:
            logsReportDataGrid.AutoGenerateColumns = false;
            logsReportDataGrid.ReadOnly = true;
            logsReportDataGrid.AllowUserToAddRows = false;
            logsReportDataGrid.Columns.Clear();

            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "session_start_time",
                DataPropertyName = "session_start_time",
                HeaderText = "Session Start Time",
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm:ss" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "session_end_time",
                DataPropertyName = "session_end_time",
                HeaderText = "Session End Time",
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm:ss" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "username",
                DataPropertyName = "username",
                HeaderText = "Username"
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cash_in_hand",
                DataPropertyName = "cash_in_hand",
                HeaderText = "Cash in Hand",
                DefaultCellStyle = { Format = "N2" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cash_amount",
                DataPropertyName = "cash_amount",
                HeaderText = "Cash Amount",
                DefaultCellStyle = { Format = "N2" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "card_amount",
                DataPropertyName = "card_amount",
                HeaderText = "Card Amount",
                DefaultCellStyle = { Format = "N2" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_sale_amount",
                DataPropertyName = "total_sale_amount",
                HeaderText = "Total Sale Amount",
                DefaultCellStyle = { Format = "N2" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_refund_amount",
                DataPropertyName = "total_refund_amount",
                HeaderText = "Total Refund Amount",
                DefaultCellStyle = { Format = "N2" }
            });
            logsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "note",
                DataPropertyName = "note",
                HeaderText = "Note",
                Width = 200
            });

            // Load everything to start
            _selectedDate = null;
            LoadLogsData();
        }

        private void LoadLogsData()
        {
            try
            {
                // Just in case someone drags this into a form without setting it up:
                if (logsReportDataGrid == null || logsSearchText == null || selectLogDateTime == null)
                {
                    MessageBox.Show(
                        "One or more controls are not properly initialized. Check your designer names.",
                        "Initialization Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Build your query
                string query = @"
                    SELECT 
                        session_start_time, 
                        session_end_time, 
                        username, 
                        cash_in_hand, 
                        cash_amount, 
                        card_amount, 
                        total_sale_amount, 
                        total_refund_amount, 
                        note 
                    FROM session_logs 
                    WHERE 1=1
                ";

                string searchText = logsSearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                    query += " AND username LIKE @searchText";

                if (_selectedDate.HasValue)
                    query += " AND DATE(created_at) = @selectedDate";

                using (var conn = new MySqlConnection(_connectionString))
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchText))
                        cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                    if (_selectedDate.HasValue)
                        cmd.Parameters.AddWithValue(
                            "@selectedDate",
                            _selectedDate.Value.ToString("yyyy-MM-dd")
                        );

                    var adapter = new MySqlDataAdapter(cmd);
                    _logsTable.Clear();
                    adapter.Fill(_logsTable);
                    logsReportDataGrid.DataSource = _logsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogsSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadLogsData();
        }

        private void logsReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // display the data in the datagridview
            // cloumns are : session-start-time, session-end-time, username, cash-in-hand, cash amount,card amount, total sale amount, total refund amount, note
        }

        private void logsReportFilterBtn_Click(object sender, EventArgs e)
        {
            // This is the filter button for the logs
            // after selecting a date then pressed the filter button display data in datagridview 

        }

        private void logsSearchText_TextChanged(object sender, EventArgs e)
        {
            // This is the serach text box for the logs using username
        }

        private void selectLogDateTime_ValueChanged(object sender, EventArgs e)
        {
            // select date for filter logs 
        }

        private void LogsReportFilterBtn_Click(object sender, EventArgs e)
        {
            _selectedDate = selectLogDateTime.Value.Date;
            LoadLogsData();
        }

        private void SelectLogDateTime_ValueChanged(object sender, EventArgs e)
        {
            // We only refresh on Filter-button click,
            // so you can leave this empty (or call LoadLogsData here if you prefer).
        }
    }
}
