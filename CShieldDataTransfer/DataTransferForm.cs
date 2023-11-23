using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace CShieldDataTransfer
{
    public partial class DataTransferForm : Form
    {
        struct TStep
        {
            public bool Flag;
            public byte Layer;
            public float Times;

            public void INC_TIMES()
            {
                Times += 1;
                Thread.Sleep(900);
            }
        }

        struct TDataValue
        {
            public string[] BF1DownRight;
            public string[] BF1DownLeft;
            public string[] BF1UpRight;
            public string[] BF1UpLeft;
            public string[] BF2DownRight;
            public string[] BF2DownLeft;
            public string[] BF2UpRight;
            public string[] BF2UpLeft;
            public string[] CU1ScanRight;
            public string[] CU1ScanLeft;
            public string[] CU1CarrierRight;
            public string[] CU1CarrierLeft;
            public string[] CU2ScanRight;
            public string[] CU2ScanLeft;
            public string[] CU2CarrierRight;
            public string[] CU2CarrierLeft;
            public string[] SUSScanRight;
            public string[] SUSScanLeft;
            public string[] SUSCarrierRight;
            public string[] SUSCarrierLeft;
        }

        Thread SeqThread;
        TStep step;
        TDataValue dataVal;
        Excel.Application excelApp = null;

        #region 변수선언
        string EquipmentPath;
        //string ExcelFilePath = @"C:\Users\156607\Amkor_Project\CShieldDataTransfer\CShieldDataTransfer\";
        string ExcelFilePath = @"\\k4fs3201n\k5ee$\16. K5 Sputter 장비 자료\5.EQCELL_SENSOR_DATA\";

        private TextBox[] m_textBox;
        private CheckBox[] m_checkBox;
        private TextBox[] m_AddrTextBox;
        private Button[] m_AddrChangeBtn;
        private Button[] m_AddrSaveBtn;

        bool bDateSet;
        bool bTimeSet;
        string sHour;
        string sMin;
        string sSecond;
        string sSelectDate;

        bool bCS_01;
        bool bCS_S01;
        bool bCS_S02;
        bool bCS_S03;
        bool bCS_S04;
        bool bCS_S05;
        string sEquipmentModel;
        int iEqNum;
        bool[] bAddrChange;

        // Sequence에서 사용 할 변수////////
        byte strMode;
        byte strCtrl;
        byte strSts;

        const byte MODE_IDLE = 0;
        const byte MODE_START = 1;

        const byte CTRL_IDLE = 0;
        const byte CTRL_RUN = 1;
        const byte CTRL_RUNNING = 2;
        const byte CTRL_ABORT = 3;

        const byte STS_IDLE = 0;
        const byte STS_START_ING = 1;
        const byte STS_START_END = 2;
        const byte STS_ABORTOK = 5;
        ///////////////////////////////////
        #endregion        
               
        public DataTransferForm()
        {
            InitializeComponent();
        }

        private void DataTransferForm_Load(object sender, EventArgs e)
        {                        
            comboBox_Hour.SelectedIndex = 0;
            comboBox_Min.SelectedIndex = 0;
            comboBox_Second.SelectedIndex = 0;

            excelApp = new Excel.Application();

            m_textBox = new TextBox[20] {
                textBox_CS01_BF1DownRight, textBox_CS01_BF1DownLeft, textBox_CS01_BF1UpRight, textBox_CS01_BF1UpLeft,
                textBox_CS01_BF2DownRight, textBox_CS01_BF2DownLeft, textBox_CS01_BF2UpRight, textBox_CS01_BF2UpLeft,
                textBox_CS01_CU1ScanRight, textBox_CS01_CU1CarrierRight, textBox_CS01_CU1CarrierLeft, textBox_CS01_CU1ScanLeft,
                textBox_CS01_CU2ScanRight, textBox_CS01_CU2CarrierRight, textBox_CS01_CU2CarrierLeft, textBox_CS01_CU2ScanLeft,
                textBox_CS01_SUSScanRight, textBox_CS01_SUSCarrierRight, textBox_CS01_SUSCarrierLeft, textBox_CS01_SUSScanLeft };

            m_checkBox = new CheckBox[6] {
                checkBox_CS_01, checkBox_CS_S01, checkBox_CS_S02, checkBox_CS_S03, checkBox_CS_S04, checkBox_CS_S05 };

            m_AddrTextBox = new TextBox[24] {
                txtBox_Eq1_Addr1, txtBox_Eq1_Addr2, txtBox_Eq1_Addr3, txtBox_Eq1_Addr4,
                txtBox_Eq2_Addr1, txtBox_Eq2_Addr2, txtBox_Eq2_Addr3, txtBox_Eq2_Addr4,
                txtBox_Eq3_Addr1, txtBox_Eq3_Addr2, txtBox_Eq3_Addr3, txtBox_Eq3_Addr4,
                txtBox_Eq4_Addr1, txtBox_Eq4_Addr2, txtBox_Eq4_Addr3, txtBox_Eq4_Addr4,
                txtBox_Eq5_Addr1, txtBox_Eq5_Addr2, txtBox_Eq5_Addr3, txtBox_Eq5_Addr4,
                txtBox_Eq6_Addr1, txtBox_Eq6_Addr2, txtBox_Eq6_Addr3, txtBox_Eq6_Addr4
            };

            m_AddrChangeBtn = new Button[6] {
                btn_Eq1_Change, btn_Eq2_Change, btn_Eq3_Change, btn_Eq4_Change, btn_Eq5_Change, btn_Eq6_Change };

            m_AddrSaveBtn = new Button[6] {
                btn_Eq1_Save, btn_Eq2_Save, btn_Eq3_Save, btn_Eq4_Save, btn_Eq5_Save, btn_Eq6_Save };

            dataVal.BF1DownRight = new string[6];
            dataVal.BF1DownLeft = new string[6];
            dataVal.BF1UpRight = new string[6];
            dataVal.BF1UpLeft = new string[6];
            dataVal.BF2DownRight = new string[6];
            dataVal.BF2DownLeft = new string[6];
            dataVal.BF2UpRight = new string[6];
            dataVal.BF2UpLeft = new string[6];
            dataVal.CU1ScanRight = new string[6];
            dataVal.CU1ScanLeft = new string[6];
            dataVal.CU1CarrierRight = new string[6];
            dataVal.CU1CarrierLeft = new string[6];
            dataVal.CU2ScanRight = new string[6];
            dataVal.CU2ScanLeft = new string[6];
            dataVal.CU2CarrierRight = new string[6];
            dataVal.CU2CarrierLeft = new string[6];
            dataVal.SUSScanRight = new string[6];
            dataVal.SUSScanLeft = new string[6];
            dataVal.SUSCarrierRight = new string[6];
            dataVal.SUSCarrierLeft = new string[6];
            
            Displaytimer.Enabled = true;

            for (int i=0; i<24; i++)
            {
                m_AddrTextBox[i].Enabled = false;
            }

            bAddrChange = new bool[] { false, false, false, false, false, false };

            btn_Eq1_Save.Enabled = false;
            btn_Eq2_Save.Enabled = false;
            btn_Eq3_Save.Enabled = false;
            btn_Eq4_Save.Enabled = false;
            btn_Eq5_Save.Enabled = false;
            btn_Eq6_Save.Enabled = false;

            EQ_ADDRESS_LOAD("CS-01.txt", 0);
            EQ_ADDRESS_LOAD("CS-S01.txt", 4);
            EQ_ADDRESS_LOAD("CS-S02.txt", 8);
            EQ_ADDRESS_LOAD("CS-S03.txt", 12);
            EQ_ADDRESS_LOAD("CS-S04.txt", 16);
            EQ_ADDRESS_LOAD("CS-S05.txt", 20);

            SeqThread = new Thread(DATA_TRANSFER_THREAD);
            SeqThread.IsBackground = true;
            SeqThread.Start();
        }

        private void DataTransferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Displaytimer.Enabled = false;
            FreeThread();
        }

        private void FreeThread()
        {
            SeqThread.Abort();
            this.Dispose();
        }

        private void EQ_ADDRESS_LOAD(string FileName, int offSet)
        {
            string sTmpData;
            //string FilePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\EqAddress\" + FileName));
            string FilePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"EqAddress\" + FileName));

            if (File.Exists(FilePath))
            {
                byte[] bytes;
                using (var fs = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, (int)fs.Length);
                    sTmpData = Encoding.Default.GetString(bytes);

                    char sp = '.';
                    string[] spString = sTmpData.Split(sp);
                    for (int i = 0; i < spString.Length; i++)
                    {
                        m_AddrTextBox[i + offSet].Text = spString[i];                        
                    }
                }
            }
        }

        #region THREAD
        private void DATA_TRANSFER_THREAD()
        {
            try
            {
                while (true)
                {
                    if (strCtrl == CTRL_ABORT)
                    {
                        AlarmAction("Abort");
                    }

                    Data_Transfer_Progress();

                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "알림");
            }
        }
        #endregion

        private void AlarmAction(string AAction)
        {
            if (AAction == "Abort")
            {
                strMode = MODE_IDLE;
                strCtrl = CTRL_IDLE;
                strSts = STS_ABORTOK;                
            }
        }

        private void Data_Transfer_Progress()
        {
            if ((strMode == MODE_START) && (strCtrl == CTRL_RUN))
            {
                step.Flag = true;
                step.Layer = 1;
                step.Times = 1;
                
                for (int i=0; i<6; i++)
                {
                    dataVal.BF1DownRight[i] = null;
                    dataVal.BF1DownLeft[i] = null;
                    dataVal.BF1UpRight[i] = null;
                    dataVal.BF1UpLeft[i] = null;
                    dataVal.BF2DownRight[i] = null;
                    dataVal.BF2DownLeft[i] = null;
                    dataVal.BF2UpRight[i] = null;
                    dataVal.BF2UpLeft[i] = null;
                    dataVal.CU1ScanRight[i] = null;
                    dataVal.CU1ScanLeft[i] = null;
                    dataVal.CU1CarrierRight[i] = null;
                    dataVal.CU1CarrierLeft[i] = null;
                    dataVal.CU2ScanRight[i] = null;
                    dataVal.CU2ScanLeft[i] = null;
                    dataVal.CU2CarrierRight[i] = null;
                    dataVal.CU2CarrierLeft[i] = null;
                    dataVal.SUSScanRight[i] = null;
                    dataVal.SUSScanLeft[i] = null;
                    dataVal.SUSCarrierRight[i] = null;
                    dataVal.SUSCarrierLeft[i] = null;
                }

                this.Invoke(new Action(delegate ()
                {
                    if (label_dataTransferTime.Text != "--")
                    {
                        label_dataTransferTime.Text = "--";
                    }
                }));

                strCtrl = CTRL_RUNNING;
                strSts = STS_START_ING;
            }
            else if ((strMode == MODE_START) && (strCtrl == CTRL_RUNNING))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            P_DATA_PARSING_TIME_CHECK();
                        }
                        break;

                    case 2:
                        {
                            P_EQUIPMENT_CHECK(11, 19);
                        }
                        break;

                    case 11:
                        {
                            P_DATA_PARSING("BF1", "BF1_DOWN");
                        }
                        break;

                    case 12:
                        {
                            P_DATA_PARSING("BF1", "BF1_UP");
                        }
                        break;

                    case 13:
                        {
                            P_DATA_PARSING("BF2", "BF2_DOWN");
                        }
                        break;

                    case 14:
                        {
                            P_DATA_PARSING("BF2", "BF2_UP");
                        }
                        break;

                    case 15:
                        {
                            P_DATA_PARSING("CU1", "CU1");
                        }
                        break;

                    case 16:
                        {
                            P_DATA_PARSING("CU2", "CU2");
                        }
                        break;

                    case 17:
                        {
                            P_DATA_PARSING("SUS", "SUS");
                        }
                        break;

                    case 18:
                        {
                            P_DATA_SEND(2);
                        }
                        break;

                    case 19:
                        {
                            P_DATA_TRANSFER_END();
                        }
                        break;
                }
            }
        }

        #region FUNCTION
        private void P_DATA_PARSING_TIME_CHECK()
        {
            if (step.Flag)
            {                
                step.Flag = false;
                step.Times = 1;
            }
            else
            {
                if (bTimeSet)
                {
                    string sCurTime = DateTime.Now.ToString("HH:mm:ss");
                    string sTime = sHour + ":" + sMin + ":" + sSecond;

                    if (sTime == sCurTime)
                    {
                        step.Flag = true;
                        step.Layer++;
                    }
                    else
                    {
                        step.INC_TIMES();
                    }
                }
                else
                {
                    step.Flag = true;
                    step.Layer++;
                }                      
            }
        }

        private void P_EQUIPMENT_CHECK(byte nStep, byte nStep2)
        {
            if (bCS_01)
            {
                sEquipmentModel = "CS-01";
                bCS_01 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else if (bCS_S01)
            {
                sEquipmentModel = "CS-S01";
                bCS_S01 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else if (bCS_S02)
            {
                sEquipmentModel = "CS-S02";
                bCS_S02 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else if (bCS_S03)
            {
                sEquipmentModel = "CS-S03";
                bCS_S03 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else if (bCS_S04)
            {
                sEquipmentModel = "CS-S04";
                bCS_S04 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else if (bCS_S05)
            {
                sEquipmentModel = "CS-S05";
                bCS_S05 = false;

                step.Flag = true;
                step.Layer = nStep;
            }
            else
            {
                step.Flag = true;
                step.Layer = nStep2;
            }            
        }

        private void P_DATA_PARSING(string sFolderName, string sFileName)
        {
            if (step.Flag)
            {
                if (F_DATA_READ(sFolderName, sFileName))
                {                    
                    Thread.Sleep(200);

                    step.Flag = false;
                    step.Times = 1;
                }
                else
                {
                    strCtrl = CTRL_ABORT;
                }                
            }
            else
            {
                step.Flag = true;
                step.Layer++;
            }
        }

        private bool F_DATA_READ(string FolderName, string FileName)
        {
            string[] sAddr = new string[] { null, null, null, null };

            try
            {
                if (sEquipmentModel == "CS-01")
                {                    
                    for (int i=0; i<4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.101.42\log\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\log\\SENSOR\\";
                    iEqNum = 0;
                }
                else if (sEquipmentModel == "CS-S01")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i + 4].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.141.20\sntek\LOG\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\sntek\\LOG\\SENSOR\\";
                    iEqNum = 1;
                }
                else if (sEquipmentModel == "CS-S02")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i + 8].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.141.14\sntek\LOG\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\sntek\\LOG\\SENSOR\\";
                    iEqNum = 2;
                }
                else if (sEquipmentModel == "CS-S03")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i + 12].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.162.10\log\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\log\\SENSOR\\";
                    iEqNum = 3;
                }
                else if (sEquipmentModel == "CS-S04")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i + 16].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.162.11\log\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\log\\SENSOR\\";
                    iEqNum = 4;
                }
                else if (sEquipmentModel == "CS-S05")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sAddr[i] = m_AddrTextBox[i + 20].Text.ToString().Trim();
                    }

                    //EquipmentPath = @"\\10.142.162.30\log\SENSOR\";
                    EquipmentPath = "\\\\" + sAddr[0] + "." + sAddr[1] + "." + sAddr[2] + "." + sAddr[3] + "\\log\\SENSOR\\";
                    iEqNum = 5;
                }

                if (bDateSet)
                {
                    if (File.Exists(EquipmentPath + sSelectDate + "\\" + FolderName + "\\" + FileName + ".csv"))
                    {
                        ImportExcelData_Read(EquipmentPath + sSelectDate + "\\" + FolderName + "\\" + FileName + ".csv", iEqNum, FileName);
                        return true;
                    }
                    else
                    {                        
                        MessageBox.Show("로그 파일이 존재하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    string sToday = DateTime.Now.ToString("yyyyMMdd");

                    if (File.Exists(EquipmentPath + sToday + "\\" + FolderName + "\\" + FileName + ".csv"))
                    {
                        ImportExcelData_Read(EquipmentPath + sToday + "\\" + FolderName + "\\" + FileName + ".csv", iEqNum, FileName);
                        return true;
                    }
                    else
                    {                        
                        MessageBox.Show("로그 파일이 존재하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }                                               
            }
            catch (Exception ex)  // 엑셀파일이 다른 프로그렘에서 이미 열었거나 에러가 발생하면 에러를 출력해준다.
            {
                MessageBox.Show(ex.Message, "알림");
                return false;
            }
        }

        public void ImportExcelData_Read(string fileName, int eqNum, string source)
        {
            uint duCnt = 0;

            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');

                if (source == "BF1_DOWN")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.BF1DownRight[eqNum] = data[0];
                        dataVal.BF1DownLeft[eqNum] = data[1];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "BF1_UP")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.BF1UpRight[eqNum] = data[0];
                        dataVal.BF1UpLeft[eqNum] = data[1];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "BF2_DOWN")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.BF2DownRight[eqNum] = data[0];
                        dataVal.BF2DownLeft[eqNum] = data[1];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "BF2_UP")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.BF2UpRight[eqNum] = data[0];
                        dataVal.BF2UpLeft[eqNum] = data[1];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "CU1")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0") || (data[2] == "0") || (data[3] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.CU1ScanRight[eqNum] = data[0];
                        dataVal.CU1CarrierRight[eqNum] = data[1];
                        dataVal.CU1CarrierLeft[eqNum] = data[2];
                        dataVal.CU1ScanLeft[eqNum] = data[3];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "CU2")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0") || (data[2] == "0") || (data[3] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.CU2ScanRight[eqNum] = data[0];
                        dataVal.CU2CarrierRight[eqNum] = data[1];
                        dataVal.CU2CarrierLeft[eqNum] = data[2];
                        dataVal.CU2ScanLeft[eqNum] = data[3];

                        sr.Close();
                        break;
                    }
                }
                else if (source == "SUS")
                {
                    if ((duCnt == 0) || (data[0] == "0") || (data[1] == "0") || (data[2] == "0") || (data[3] == "0"))
                    {
                        duCnt++;
                    }
                    else
                    {
                        dataVal.SUSScanRight[eqNum] = data[0];
                        dataVal.SUSCarrierRight[eqNum] = data[1];
                        dataVal.SUSCarrierLeft[eqNum] = data[2];
                        dataVal.SUSScanLeft[eqNum] = data[3];

                        sr.Close();
                        break;
                    }
                }
            }
        }

        private void P_DATA_SEND(byte nStep)
        {
            if (step.Flag)
            {
                writeToExcel(sEquipmentModel, iEqNum);
                
                step.Flag = false;
                step.Times = 1;
            }
            else
            {
                Thread.Sleep(500);

                step.Flag = true;
                step.Layer = nStep;
            }
        }

        private void writeToExcel(string sEquipName, int eqNum)
        {
            Excel.Workbook workBook = null; 
            Excel.Worksheet workSheet = null;

            int i_RowNum = 0;
            
            try
            {
                string sYear;
                int iMonth;
                int iDay;

                if (bDateSet)
                {
                    sYear = DateTime.Now.Year.ToString();

                    string sMonth = sSelectDate.Substring(4, 2);
                    int ConvMonth = Convert.ToInt32(sMonth);
                    iMonth = ConvMonth;                    

                    string sDay = sSelectDate.Substring(6, 2);
                    int ConvDay = Convert.ToInt32(sDay);
                    iDay = ConvDay;
                }
                else
                {
                    sYear = DateTime.Now.Year.ToString();
                    iMonth = DateTime.Now.Month;
                    iDay = DateTime.Now.Day;
                }

                workBook = excelApp.Workbooks.Open(ExcelFilePath + "AutoData_" + sYear + ".xlsx");                
                workSheet = workBook.Worksheets.get_Item(iMonth) as Excel.Worksheet;
               
                if (sEquipName == "CS-01")
                {
                    i_RowNum = 5;
                }
                else if (sEquipName == "CS-S01")
                {
                    i_RowNum = 31;
                }
                else if (sEquipName == "CS-S02")
                {
                    i_RowNum = 57;
                }
                else if (sEquipName == "CS-S03")
                {
                    i_RowNum = 83;
                }
                else if (sEquipName == "CS-S04")
                {
                    i_RowNum = 109;
                }
                else if (sEquipName == "CS-S05")
                {
                    i_RowNum = 135;
                }

                workSheet.Cells[i_RowNum, iDay + 6] = dataVal.CU2ScanLeft[eqNum];
                workSheet.Cells[i_RowNum + 1, iDay + 6] = dataVal.CU2CarrierLeft[eqNum];
                workSheet.Cells[i_RowNum + 2, iDay + 6] = dataVal.CU2CarrierRight[eqNum];
                workSheet.Cells[i_RowNum + 3, iDay + 6] = dataVal.CU2ScanRight[eqNum];

                workSheet.Cells[i_RowNum + 4, iDay + 6] = dataVal.BF2DownLeft[eqNum];
                workSheet.Cells[i_RowNum + 5, iDay + 6] = dataVal.BF2UpLeft[eqNum];
                workSheet.Cells[i_RowNum + 6, iDay + 6] = dataVal.BF2DownRight[eqNum];
                workSheet.Cells[i_RowNum + 7, iDay + 6] = dataVal.BF2UpRight[eqNum];

                workSheet.Cells[i_RowNum + 8, iDay + 6] = dataVal.CU1ScanLeft[eqNum];
                workSheet.Cells[i_RowNum + 9, iDay + 6] = dataVal.CU1CarrierLeft[eqNum];
                workSheet.Cells[i_RowNum + 10, iDay + 6] = dataVal.CU1CarrierRight[eqNum];
                workSheet.Cells[i_RowNum + 11, iDay + 6] = dataVal.CU1ScanRight[eqNum];

                workSheet.Cells[i_RowNum + 12, iDay + 6] = dataVal.BF1DownLeft[eqNum];
                workSheet.Cells[i_RowNum + 13, iDay + 6] = dataVal.BF1UpLeft[eqNum];
                workSheet.Cells[i_RowNum + 14, iDay + 6] = dataVal.BF1DownRight[eqNum];
                workSheet.Cells[i_RowNum + 15, iDay + 6] = dataVal.BF1UpRight[eqNum];

                workSheet.Cells[i_RowNum + 16, iDay + 6] = dataVal.SUSScanLeft[eqNum];
                workSheet.Cells[i_RowNum + 17, iDay + 6] = dataVal.SUSCarrierLeft[eqNum];
                workSheet.Cells[i_RowNum + 18, iDay + 6] = dataVal.SUSCarrierRight[eqNum];
                workSheet.Cells[i_RowNum + 19, iDay + 6] = dataVal.SUSScanRight[eqNum];

                workBook.Save();

                workBook.Close();
                excelApp.Quit();

                //ReleaseExcelObject(workBook);
                //ReleaseExcelObject(excelApp);                
            }
            catch (Exception ex)
            {
                if (workBook != null)
                    workBook.Close();

                if (excelApp != null)
                    excelApp.Quit();                
            }
        }        

        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void P_DATA_TRANSFER_END()
        {
            this.Invoke(new Action(delegate ()
            {
                if (label_dataTransferTime.Text == "--")
                {
                    label_dataTransferTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (checkBoxAllSelect.Checked != false)
                {
                    checkBoxAllSelect.Checked = false;
                }

                if (checkBox_CS_01.Checked != false)
                {
                    checkBox_CS_01.Checked = false;
                }

                if (checkBox_CS_S01.Checked != false)
                {
                    checkBox_CS_S01.Checked = false;
                }

                if (checkBox_CS_S02.Checked != false)
                {
                    checkBox_CS_S02.Checked = false;
                }

                if (checkBox_CS_S03.Checked != false)
                {
                    checkBox_CS_S03.Checked = false;
                }

                if (checkBox_CS_S04.Checked != false)
                {
                    checkBox_CS_S04.Checked = false;
                }

                if (checkBox_CS_S05.Checked != false)
                {
                    checkBox_CS_S05.Checked = false;
                }
            }));

            strMode = MODE_IDLE;
            strCtrl = CTRL_IDLE;
            strSts = STS_START_END;            
        }
        #endregion

        #region DISPLAY
        private void Displaytimer_Tick(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label_Time.Text = DateTime.Now.ToString("HH:mm:ss");            

            sHour = comboBox_Hour.Text;
            sMin = comboBox_Min.Text;
            sSecond = comboBox_Second.Text;

            if (bTimeSet)
            {
                if (strCtrl == CTRL_IDLE)
                {
                    if (!checkBox_DateSelect.Enabled)
                    {
                        checkBox_DateSelect.Enabled = true;                        
                    }                    
                    
                    if (!checkBox_TimeSet.Enabled)
                    {
                        checkBox_TimeSet.Enabled = true;
                    }

                    if (!comboBox_Hour.Enabled)
                    {
                        comboBox_Hour.Enabled = true;
                    }

                    if (!comboBox_Min.Enabled)
                    {
                        comboBox_Min.Enabled = true;
                    }

                    if (!comboBox_Second.Enabled)
                    {
                        comboBox_Second.Enabled = true;
                    }

                    if (!btn_Start.Enabled)
                    {
                        btn_Start.Enabled = true;
                    }

                    if (btn_Stop.Enabled != false)
                    {
                        btn_Stop.Enabled = false;
                    }

                    if (!checkBoxAllSelect.Enabled)
                    {
                        checkBoxAllSelect.Enabled = true;
                    }

                    for (int i=0; i<6; i++)
                    {
                        if (!m_checkBox[i].Enabled)
                        {
                            m_checkBox[i].Enabled = true;
                        }

                        if (!bAddrChange[i])
                        {
                            if (!m_AddrChangeBtn[i].Enabled)
                            {
                                m_AddrChangeBtn[i].Enabled = true;
                            }
                        }                        
                    }                    
                }
                else
                {
                    if (checkBox_DateSelect.Enabled != false)
                    {
                        checkBox_DateSelect.Enabled = false;                        
                    }                    

                    if (checkBox_TimeSet.Enabled != false)
                    {
                        checkBox_TimeSet.Enabled = false;
                    }

                    if (comboBox_Hour.Enabled != false)
                    {
                        comboBox_Hour.Enabled = false;
                    }

                    if (comboBox_Min.Enabled != false)
                    {
                        comboBox_Min.Enabled = false;
                    }

                    if (comboBox_Second.Enabled != false)
                    {
                        comboBox_Second.Enabled = false;
                    }

                    if (btn_Start.Enabled != false)
                    {
                        btn_Start.Enabled = false;
                    }

                    if (!btn_Stop.Enabled)
                    {
                        btn_Stop.Enabled = true;
                    }

                    if (checkBoxAllSelect.Enabled != false)
                    {
                        checkBoxAllSelect.Enabled = false;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        if (m_checkBox[i].Enabled != false)
                        {
                            m_checkBox[i].Enabled = false;
                        }

                        if (m_AddrChangeBtn[i].Enabled != false)
                        {
                            m_AddrChangeBtn[i].Enabled = false;
                        }
                    }
                }
            }
            else
            {                
                if (comboBox_Hour.Enabled != false)
                {
                    comboBox_Hour.Enabled = false;
                }

                if (comboBox_Min.Enabled != false)
                {
                    comboBox_Min.Enabled = false;
                }

                if (comboBox_Second.Enabled != false)
                {
                    comboBox_Second.Enabled = false;
                }

                if (strCtrl == CTRL_IDLE)
                {
                    if (!checkBox_DateSelect.Enabled)
                    {
                        checkBox_DateSelect.Enabled = true;                        
                    }                    

                    if (!checkBox_TimeSet.Enabled)
                    {
                        checkBox_TimeSet.Enabled = true;
                    }

                    if (!btn_Start.Enabled)
                    {
                        btn_Start.Enabled = true;
                    }

                    if (btn_Stop.Enabled != false)
                    {
                        btn_Stop.Enabled = false;
                    }

                    if (!checkBoxAllSelect.Enabled)
                    {
                        checkBoxAllSelect.Enabled = true;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        if (!m_checkBox[i].Enabled)
                        {
                            m_checkBox[i].Enabled = true;
                        }

                        if (!bAddrChange[i])
                        {
                            if (!m_AddrChangeBtn[i].Enabled)
                            {
                                m_AddrChangeBtn[i].Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    if (checkBox_DateSelect.Enabled != false)
                    {
                        checkBox_DateSelect.Enabled = false;                        
                    }                    

                    if (checkBox_TimeSet.Enabled != false)
                    {
                        checkBox_TimeSet.Enabled = false;
                    }

                    if (btn_Start.Enabled != false)
                    {
                        btn_Start.Enabled = false;
                    }

                    if (!btn_Stop.Enabled)
                    {
                        btn_Stop.Enabled = true;
                    }

                    if (checkBoxAllSelect.Enabled != false)
                    {
                        checkBoxAllSelect.Enabled = false;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        if (m_checkBox[i].Enabled != false)
                        {
                            m_checkBox[i].Enabled = false;
                        }

                        if (m_AddrChangeBtn[i].Enabled != false)
                        {
                            m_AddrChangeBtn[i].Enabled = false;
                        }
                    }
                }
            }

            if (bDateSet)
            {
                if (!monthCalendar1.Enabled)
                {
                    monthCalendar1.Enabled = true;
                }
            }
            else
            {
                if (monthCalendar1.Enabled != false)
                {
                    monthCalendar1.Enabled = false;
                }
            }

            if (strMode == MODE_IDLE)
            {
                label_Mode.Text = "Idle";
            }
            else if (strMode == MODE_START)
            {
                label_Mode.Text = "Start";
            }

            if (strCtrl == CTRL_IDLE)
            {
                label_Ctrl.Text = "Idle";
            }
            else if (strCtrl == CTRL_RUN)
            {
                label_Ctrl.Text = "Run";
            }
            else if (strCtrl == CTRL_RUNNING)
            {
                label_Ctrl.Text = "Running";
            }
            else if (strCtrl == CTRL_ABORT)
            {
                label_Ctrl.Text = "Abort";
            }

            if (strSts == STS_IDLE)
            {
                label_Sts.Text = "Idle";
            }
            else if (strSts == STS_START_ING)
            {
                label_Sts.Text = "Start Ing";
            }
            else if (strSts == STS_START_END)
            {
                label_Sts.Text = "Start End";
            }
            else if (strSts == STS_ABORTOK)
            {
                label_Sts.Text = "AbortOk";
            }


            textBox_CS01_BF1DownRight.Text = dataVal.BF1DownRight[0];
            textBox_CS01_BF1DownLeft.Text = dataVal.BF1DownLeft[0];
            textBox_CS01_BF1UpRight.Text = dataVal.BF1UpRight[0];
            textBox_CS01_BF1UpLeft.Text = dataVal.BF1UpLeft[0];

            textBox_CS01_BF2DownRight.Text = dataVal.BF2DownRight[0];
            textBox_CS01_BF2DownLeft.Text = dataVal.BF2DownLeft[0];
            textBox_CS01_BF2UpRight.Text = dataVal.BF2UpRight[0];
            textBox_CS01_BF2UpLeft.Text = dataVal.BF2UpLeft[0];

            textBox_CS01_CU1ScanRight.Text = dataVal.CU1ScanRight[0];
            textBox_CS01_CU1CarrierRight.Text = dataVal.CU1CarrierRight[0];
            textBox_CS01_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[0];
            textBox_CS01_CU1ScanLeft.Text = dataVal.CU1ScanLeft[0];

            textBox_CS01_CU2ScanRight.Text = dataVal.CU2ScanRight[0];
            textBox_CS01_CU2CarrierRight.Text = dataVal.CU2CarrierRight[0];
            textBox_CS01_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[0];
            textBox_CS01_CU2ScanLeft.Text = dataVal.CU2ScanLeft[0];

            textBox_CS01_SUSScanRight.Text = dataVal.SUSScanRight[0];
            textBox_CS01_SUSCarrierRight.Text = dataVal.SUSCarrierRight[0];
            textBox_CS01_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[0];
            textBox_CS01_SUSScanLeft.Text = dataVal.SUSScanLeft[0];

            textBox_CSS01_BF1DownRight.Text = dataVal.BF1DownRight[1];
            textBox_CSS01_BF1DownLeft.Text = dataVal.BF1DownLeft[1];
            textBox_CSS01_BF1UpRight.Text = dataVal.BF1UpRight[1];
            textBox_CSS01_BF1UpLeft.Text = dataVal.BF1UpLeft[1];

            textBox_CSS01_BF2DownRight.Text = dataVal.BF2DownRight[1];
            textBox_CSS01_BF2DownLeft.Text = dataVal.BF2DownLeft[1];
            textBox_CSS01_BF2UpRight.Text = dataVal.BF2UpRight[1];
            textBox_CSS01_BF2UpLeft.Text = dataVal.BF2UpLeft[1];

            textBox_CSS01_CU1ScanRight.Text = dataVal.CU1ScanRight[1];
            textBox_CSS01_CU1CarrierRight.Text = dataVal.CU1CarrierRight[1];
            textBox_CSS01_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[1];
            textBox_CSS01_CU1ScanLeft.Text = dataVal.CU1ScanLeft[1];

            textBox_CSS01_CU2ScanRight.Text = dataVal.CU2ScanRight[1];
            textBox_CSS01_CU2CarrierRight.Text = dataVal.CU2CarrierRight[1];
            textBox_CSS01_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[1];
            textBox_CSS01_CU2ScanLeft.Text = dataVal.CU2ScanLeft[1];

            textBox_CSS01_SUSScanRight.Text = dataVal.SUSScanRight[1];
            textBox_CSS01_SUSCarrierRight.Text = dataVal.SUSCarrierRight[1];
            textBox_CSS01_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[1];
            textBox_CSS01_SUSScanLeft.Text = dataVal.SUSScanLeft[1];

            textBox_CSS02_BF1DownRight.Text = dataVal.BF1DownRight[2];
            textBox_CSS02_BF1DownLeft.Text = dataVal.BF1DownLeft[2];
            textBox_CSS02_BF1UpRight.Text = dataVal.BF1UpRight[2];
            textBox_CSS02_BF1UpLeft.Text = dataVal.BF1UpLeft[2];

            textBox_CSS02_BF2DownRight.Text = dataVal.BF2DownRight[2];
            textBox_CSS02_BF2DownLeft.Text = dataVal.BF2DownLeft[2];
            textBox_CSS02_BF2UpRight.Text = dataVal.BF2UpRight[2];
            textBox_CSS02_BF2UpLeft.Text = dataVal.BF2UpLeft[2];

            textBox_CSS02_CU1ScanRight.Text = dataVal.CU1ScanRight[2];
            textBox_CSS02_CU1CarrierRight.Text = dataVal.CU1CarrierRight[2];
            textBox_CSS02_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[2];
            textBox_CSS02_CU1ScanLeft.Text = dataVal.CU1ScanLeft[2];

            textBox_CSS02_CU2ScanRight.Text = dataVal.CU2ScanRight[2];
            textBox_CSS02_CU2CarrierRight.Text = dataVal.CU2CarrierRight[2];
            textBox_CSS02_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[2];
            textBox_CSS02_CU2ScanLeft.Text = dataVal.CU2ScanLeft[2];

            textBox_CSS02_SUSScanRight.Text = dataVal.SUSScanRight[2];
            textBox_CSS02_SUSCarrierRight.Text = dataVal.SUSCarrierRight[2];
            textBox_CSS02_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[2];
            textBox_CSS02_SUSScanLeft.Text = dataVal.SUSScanLeft[2];

            textBox_CSS03_BF1DownRight.Text = dataVal.BF1DownRight[3];
            textBox_CSS03_BF1DownLeft.Text = dataVal.BF1DownLeft[3];
            textBox_CSS03_BF1UpRight.Text = dataVal.BF1UpRight[3];
            textBox_CSS03_BF1UpLeft.Text = dataVal.BF1UpLeft[3];

            textBox_CSS03_BF2DownRight.Text = dataVal.BF2DownRight[3];
            textBox_CSS03_BF2DownLeft.Text = dataVal.BF2DownLeft[3];
            textBox_CSS03_BF2UpRight.Text = dataVal.BF2UpRight[3];
            textBox_CSS03_BF2UpLeft.Text = dataVal.BF2UpLeft[3];

            textBox_CSS03_CU1ScanRight.Text = dataVal.CU1ScanRight[3];
            textBox_CSS03_CU1CarrierRight.Text = dataVal.CU1CarrierRight[3];
            textBox_CSS03_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[3];
            textBox_CSS03_CU1ScanLeft.Text = dataVal.CU1ScanLeft[3];

            textBox_CSS03_CU2ScanRight.Text = dataVal.CU2ScanRight[3];
            textBox_CSS03_CU2CarrierRight.Text = dataVal.CU2CarrierRight[3];
            textBox_CSS03_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[3];
            textBox_CSS03_CU2ScanLeft.Text = dataVal.CU2ScanLeft[3];

            textBox_CSS03_SUSScanRight.Text = dataVal.SUSScanRight[3];
            textBox_CSS03_SUSCarrierRight.Text = dataVal.SUSCarrierRight[3];
            textBox_CSS03_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[3];
            textBox_CSS03_SUSScanLeft.Text = dataVal.SUSScanLeft[3];

            textBox_CSS04_BF1DownRight.Text = dataVal.BF1DownRight[4];
            textBox_CSS04_BF1DownLeft.Text = dataVal.BF1DownLeft[4];
            textBox_CSS04_BF1UpRight.Text = dataVal.BF1UpRight[4];
            textBox_CSS04_BF1UpLeft.Text = dataVal.BF1UpLeft[4];

            textBox_CSS04_BF2DownRight.Text = dataVal.BF2DownRight[4];
            textBox_CSS04_BF2DownLeft.Text = dataVal.BF2DownLeft[4];
            textBox_CSS04_BF2UpRight.Text = dataVal.BF2UpRight[4];
            textBox_CSS04_BF2UpLeft.Text = dataVal.BF2UpLeft[4];

            textBox_CSS04_CU1ScanRight.Text = dataVal.CU1ScanRight[4];
            textBox_CSS04_CU1CarrierRight.Text = dataVal.CU1CarrierRight[4];
            textBox_CSS04_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[4];
            textBox_CSS04_CU1ScanLeft.Text = dataVal.CU1ScanLeft[4];

            textBox_CSS04_CU2ScanRight.Text = dataVal.CU2ScanRight[4];
            textBox_CSS04_CU2CarrierRight.Text = dataVal.CU2CarrierRight[4];
            textBox_CSS04_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[4];
            textBox_CSS04_CU2ScanLeft.Text = dataVal.CU2ScanLeft[4];

            textBox_CSS04_SUSScanRight.Text = dataVal.SUSScanRight[4];
            textBox_CSS04_SUSCarrierRight.Text = dataVal.SUSCarrierRight[4];
            textBox_CSS04_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[4];
            textBox_CSS04_SUSScanLeft.Text = dataVal.SUSScanLeft[4];

            textBox_CSS05_BF1DownRight.Text = dataVal.BF1DownRight[5];
            textBox_CSS05_BF1DownLeft.Text = dataVal.BF1DownLeft[5];
            textBox_CSS05_BF1UpRight.Text = dataVal.BF1UpRight[5];
            textBox_CSS05_BF1UpLeft.Text = dataVal.BF1UpLeft[5];

            textBox_CSS05_BF2DownRight.Text = dataVal.BF2DownRight[5];
            textBox_CSS05_BF2DownLeft.Text = dataVal.BF2DownLeft[5];
            textBox_CSS05_BF2UpRight.Text = dataVal.BF2UpRight[5];
            textBox_CSS05_BF2UpLeft.Text = dataVal.BF2UpLeft[5];

            textBox_CSS05_CU1ScanRight.Text = dataVal.CU1ScanRight[5];
            textBox_CSS05_CU1CarrierRight.Text = dataVal.CU1CarrierRight[5];
            textBox_CSS05_CU1CarrierLeft.Text = dataVal.CU1CarrierLeft[5];
            textBox_CSS05_CU1ScanLeft.Text = dataVal.CU1ScanLeft[5];

            textBox_CSS05_CU2ScanRight.Text = dataVal.CU2ScanRight[5];
            textBox_CSS05_CU2CarrierRight.Text = dataVal.CU2CarrierRight[5];
            textBox_CSS05_CU2CarrierLeft.Text = dataVal.CU2CarrierLeft[5];
            textBox_CSS05_CU2ScanLeft.Text = dataVal.CU2ScanLeft[5];

            textBox_CSS05_SUSScanRight.Text = dataVal.SUSScanRight[5];
            textBox_CSS05_SUSCarrierRight.Text = dataVal.SUSCarrierRight[5];
            textBox_CSS05_SUSCarrierLeft.Text = dataVal.SUSCarrierLeft[5];
            textBox_CSS05_SUSScanLeft.Text = dataVal.SUSScanLeft[5];
        }
        #endregion

        private void checkBox_DateSelect_Click(object sender, EventArgs e)
        {
            if (checkBox_DateSelect.Checked)
            {
                bDateSet = true;
            }
            else
            {
                bDateSet = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {            
            sSelectDate = monthCalendar1.SelectionStart.ToString("yyyyMMdd");
        }

        private void checkBox_TimeSet_Click(object sender, EventArgs e)
        {
            if (checkBox_TimeSet.Checked)
            {
                bTimeSet = true;
            }
            else
            {
                bTimeSet = false;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if ( (bAddrChange[0]) || (bAddrChange[1]) ||
                 (bAddrChange[2]) || (bAddrChange[3]) ||
                 (bAddrChange[4]) || (bAddrChange[5]) )
            {                
                MessageBox.Show("장비의 폴더 주소가 변경 중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((!checkBox_CS_01.Checked) && (!checkBox_CS_S01.Checked) &&
                (!checkBox_CS_S02.Checked) && (!checkBox_CS_S03.Checked) &&
                (!checkBox_CS_S04.Checked) && (!checkBox_CS_S05.Checked))
            {                
                MessageBox.Show("최소 한개 이상의 장비를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            strMode = MODE_START;
            strCtrl = CTRL_RUN;
            strSts = STS_IDLE;            
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            strCtrl = CTRL_ABORT;            
        }

        private void checkBoxAllSelect_Click(object sender, EventArgs e)
        {
            if (checkBoxAllSelect.Checked)
            {                
                bCS_01 = true;                
                bCS_S01 = true;                
                bCS_S02 = true;               
                bCS_S03 = true;                
                bCS_S04 = true;                
                bCS_S05 = true;

                for (int i = 0; i < 6; i++)
                {
                    m_checkBox[i].Checked = true;
                }
            }
            else
            {               
                bCS_01 = false;                
                bCS_S01 = false;                
                bCS_S02 = false;                
                bCS_S03 = false;                
                bCS_S04 = false;                
                bCS_S05 = false;

                for (int i = 0; i < 6; i++)
                {
                    m_checkBox[i].Checked = false;
                }
            }
        }

        private void checkBox_CS_01_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_01.Checked)
            {
                bCS_01 = true;
            }
            else
            {
                bCS_01 = false;
            }
        }

        private void checkBox_CS_S01_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_S01.Checked)
            {
                bCS_S01 = true;
            }
            else
            {
                bCS_S01 = false;
            }
        }

        private void checkBox_CS_S02_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_S02.Checked)
            {
                bCS_S02 = true;
            }
            else
            {
                bCS_S02 = false;
            }
        }

        private void checkBox_CS_S03_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_S03.Checked)
            {
                bCS_S03 = true;
            }
            else
            {
                bCS_S03 = false;
            }
        }

        private void checkBox_CS_S04_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_S04.Checked)
            {
                bCS_S04 = true;
            }
            else
            {
                bCS_S04 = false;
            }
        }

        private void checkBox_CS_S05_Click(object sender, EventArgs e)
        {
            if (checkBox_CS_S05.Checked)
            {
                bCS_S05 = true;
            }
            else
            {
                bCS_S05 = false;
            }
        }

        private void btn_Eq1_Change_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string EqSelect = btn.Tag.ToString();
            int i;

            btn.Enabled = false;            

            switch (EqSelect)
            {
                case "Eq1_C":
                    {
                        for (i=0; i<=3; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }
                        
                        btn_Eq1_Save.Enabled = true;
                        bAddrChange[0] = true;
                    }
                    break;

                case "Eq2_C":
                    {
                        for (i = 4; i <= 7; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }

                        btn_Eq2_Save.Enabled = true;
                        bAddrChange[1] = true;
                    }
                    break;

                case "Eq3_C":
                    {
                        for (i = 8; i <= 11; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }

                        btn_Eq3_Save.Enabled = true;
                        bAddrChange[2] = true;
                    }
                    break;

                case "Eq4_C":
                    {
                        for (i = 12; i <= 15; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }

                        btn_Eq4_Save.Enabled = true;
                        bAddrChange[3] = true;
                    }
                    break;

                case "Eq5_C":
                    {
                        for (i = 16; i <= 19; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }

                        btn_Eq5_Save.Enabled = true;
                        bAddrChange[4] = true;
                    }
                    break;

                case "Eq6_C":
                    {
                        for (i = 20; i <= 23; i++)
                        {
                            m_AddrTextBox[i].Enabled = true;
                        }

                        btn_Eq6_Save.Enabled = true;
                        bAddrChange[5] = true;
                    }
                    break;
            }
        }

        private void btn_Eq1_Save_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string EqSelect = btn.Tag.ToString();
            string[] sAddr = new string[4];
            int i;
            byte j = 0;
            bool result;
            bool bRtn = true;

            btn.Enabled = false;

            switch (EqSelect)
            {
                case "Eq1_S":
                    {
                        for (i = 0; i <= 3; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[0] = false;

                        string FileName = "CS-01.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }                                
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-01.txt", 0);
                        
                    }
                    break;

                case "Eq2_S":
                    {
                        for (i = 4; i <= 7; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[1] = false;

                        string FileName = "CS-S01.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i + 4].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-S01.txt", 4);
                        
                    }
                    break;

                case "Eq3_S":
                    {
                        for (i = 8; i <= 11; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[2] = false;

                        string FileName = "CS-S02.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i + 8].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-S02.txt", 8);
                        
                    }
                    break;

                case "Eq4_S":
                    {
                        for (i = 12; i <= 15; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[3] = false;

                        string FileName = "CS-S03.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i + 12].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-S03.txt", 12);
                        
                    }
                    break;

                case "Eq5_S":
                    {
                        for (i = 16; i <= 19; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[4] = false;

                        string FileName = "CS-S04.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i + 16].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-S04.txt", 16);
                        
                    }
                    break;

                case "Eq6_S":
                    {
                        for (i = 20; i <= 23; i++)
                        {
                            m_AddrTextBox[i].Enabled = false;
                        }

                        bAddrChange[5] = false;

                        string FileName = "CS-S05.txt";

                        for (i = 0; i <= 3; i++)
                        {
                            sAddr[i] = m_AddrTextBox[i + 20].Text.ToString().Trim();
                            result = byte.TryParse(sAddr[i], out j);
                            if (!result)
                            {
                                bRtn = false;
                                break;
                            }
                        }

                        if (!bRtn)
                        {
                            MessageBox.Show("잘못 된 주소 값이 입력되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Address_WriteFile(FileName, sAddr[0], sAddr[1], sAddr[2], sAddr[3]))
                            {
                                MessageBox.Show("주소 값이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("주소 값이 저장되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        EQ_ADDRESS_LOAD("CS-S05.txt", 20);
                    }
                    break;
            }
        }

        private bool Address_WriteFile(string fileName, string param1, string param2, string param3, string param4)
        {
            //string FilePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\EqAddress\" + fileName));
            string FilePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"EqAddress\" + fileName));
            
            try
            {                
                File.WriteAllText(FilePath, param1 + "." + param2 + "." + param3 + "." + param4, Encoding.Default);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "알림");
                return false;
            }
        }

        private void checkBox_DateSelect_MouseHover(object sender, EventArgs e)
        {            
            this.toolTip1.ToolTipTitle = "날짜 선택";                        
            this.toolTip1.Show("1. 선택 시, 해당하는 날짜의 센서 데이터를 가져옵니다. 단, 이번 년도로 한정됩니다." + "\n" +
                "2. 선택 안할 시, 오늘 날짜의 센서 데이터를 가져옵니다.", checkBox_DateSelect);
        }

        private void checkBox_DateSelect_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(checkBox_DateSelect);            
        }

        private void checkBox_TimeSet_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "시간 예약";            
            this.toolTip1.Show("1. 선택 시, 설정 한 시간이 되면 센서 데이터를 가져옵니다." + "\n" +
                "2. 선택 안할 시, 지금 즉시 센서 데이터를 가져옵니다. (단, 오전 11시 이후에 시작해야 합니다.)", checkBox_TimeSet);
        }

        private void checkBox_TimeSet_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(checkBox_TimeSet);
        }        
    }
}
