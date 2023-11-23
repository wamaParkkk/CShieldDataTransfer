
namespace CShieldDataTransfer
{
    partial class DataTransferForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTransferForm));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.Displaytimer = new System.Windows.Forms.Timer(this.components);
            this.label_Mode = new System.Windows.Forms.Label();
            this.label_Ctrl = new System.Windows.Forms.Label();
            this.label_Sts = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label_dataTransferTime = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_Hour = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox_Min = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBox_Second = new System.Windows.Forms.ComboBox();
            this.checkBox_TimeSet = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_01 = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_S01 = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_S03 = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_S02 = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_S05 = new System.Windows.Forms.CheckBox();
            this.checkBox_CS_S04 = new System.Windows.Forms.CheckBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CS_01 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_CS01_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_CS01_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_CS01_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_CS01_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_CS01_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_CS01_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_CS01_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_CS01_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_CS01_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CS01_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CS01_BF1DownRight = new System.Windows.Forms.TextBox();
            this.tabPage_CS_S01 = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox_CSS01_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox_CSS01_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox_CSS01_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox_CSS01_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox_CSS01_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox_CSS01_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox_CSS01_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox_CSS01_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox_CSS01_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox_CSS01_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS01_BF1DownRight = new System.Windows.Forms.TextBox();
            this.tabPage_CS_S02 = new System.Windows.Forms.TabPage();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox_CSS02_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox_CSS02_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox_CSS02_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox_CSS02_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.textBox_CSS02_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox_CSS02_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox_CSS02_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox_CSS02_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox_CSS02_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox_CSS02_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS02_BF1DownRight = new System.Windows.Forms.TextBox();
            this.tabPage_CS_S03 = new System.Windows.Forms.TabPage();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.textBox_CSS03_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.textBox_CSS03_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.textBox_CSS03_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.textBox_CSS03_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.textBox_CSS03_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.textBox_CSS03_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.textBox_CSS03_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.textBox_CSS03_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.textBox_CSS03_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.textBox_CSS03_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS03_BF1DownRight = new System.Windows.Forms.TextBox();
            this.tabPage_CS_S04 = new System.Windows.Forms.TabPage();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.textBox_CSS04_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label144 = new System.Windows.Forms.Label();
            this.textBox_CSS04_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.textBox_CSS04_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.textBox_CSS04_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.textBox_CSS04_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.textBox_CSS04_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label149 = new System.Windows.Forms.Label();
            this.textBox_CSS04_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.textBox_CSS04_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.textBox_CSS04_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.textBox_CSS04_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS04_BF1DownRight = new System.Windows.Forms.TextBox();
            this.tabPage_CS_S05 = new System.Windows.Forms.TabPage();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.textBox_CSS05_SUSCarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_SUSCarrierRight = new System.Windows.Forms.TextBox();
            this.label174 = new System.Windows.Forms.Label();
            this.textBox_CSS05_SUSScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_SUSScanRight = new System.Windows.Forms.TextBox();
            this.label175 = new System.Windows.Forms.Label();
            this.textBox_CSS05_CU2CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_CU2CarrierRight = new System.Windows.Forms.TextBox();
            this.label176 = new System.Windows.Forms.Label();
            this.textBox_CSS05_CU2ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_CU2ScanRight = new System.Windows.Forms.TextBox();
            this.label177 = new System.Windows.Forms.Label();
            this.textBox_CSS05_CU1CarrierLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_CU1CarrierRight = new System.Windows.Forms.TextBox();
            this.label178 = new System.Windows.Forms.Label();
            this.textBox_CSS05_CU1ScanLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_CU1ScanRight = new System.Windows.Forms.TextBox();
            this.label179 = new System.Windows.Forms.Label();
            this.textBox_CSS05_BF2UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_BF2UpRight = new System.Windows.Forms.TextBox();
            this.label180 = new System.Windows.Forms.Label();
            this.textBox_CSS05_BF2DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_BF2DownRight = new System.Windows.Forms.TextBox();
            this.label181 = new System.Windows.Forms.Label();
            this.textBox_CSS05_BF1UpLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_BF1UpRight = new System.Windows.Forms.TextBox();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.textBox_CSS05_BF1DownLeft = new System.Windows.Forms.TextBox();
            this.textBox_CSS05_BF1DownRight = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox_DateSelect = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_Eq1_Addr1 = new System.Windows.Forms.TextBox();
            this.label185 = new System.Windows.Forms.Label();
            this.txtBox_Eq1_Addr2 = new System.Windows.Forms.TextBox();
            this.txtBox_Eq1_Addr3 = new System.Windows.Forms.TextBox();
            this.label186 = new System.Windows.Forms.Label();
            this.txtBox_Eq1_Addr4 = new System.Windows.Forms.TextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.txtBox_Eq2_Addr4 = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.txtBox_Eq2_Addr3 = new System.Windows.Forms.TextBox();
            this.label189 = new System.Windows.Forms.Label();
            this.txtBox_Eq2_Addr2 = new System.Windows.Forms.TextBox();
            this.label190 = new System.Windows.Forms.Label();
            this.txtBox_Eq2_Addr1 = new System.Windows.Forms.TextBox();
            this.txtBox_Eq4_Addr4 = new System.Windows.Forms.TextBox();
            this.label191 = new System.Windows.Forms.Label();
            this.txtBox_Eq4_Addr3 = new System.Windows.Forms.TextBox();
            this.label192 = new System.Windows.Forms.Label();
            this.txtBox_Eq4_Addr2 = new System.Windows.Forms.TextBox();
            this.label193 = new System.Windows.Forms.Label();
            this.txtBox_Eq4_Addr1 = new System.Windows.Forms.TextBox();
            this.txtBox_Eq3_Addr4 = new System.Windows.Forms.TextBox();
            this.label194 = new System.Windows.Forms.Label();
            this.txtBox_Eq3_Addr3 = new System.Windows.Forms.TextBox();
            this.label195 = new System.Windows.Forms.Label();
            this.txtBox_Eq3_Addr2 = new System.Windows.Forms.TextBox();
            this.label196 = new System.Windows.Forms.Label();
            this.txtBox_Eq3_Addr1 = new System.Windows.Forms.TextBox();
            this.txtBox_Eq6_Addr4 = new System.Windows.Forms.TextBox();
            this.label197 = new System.Windows.Forms.Label();
            this.txtBox_Eq6_Addr3 = new System.Windows.Forms.TextBox();
            this.label198 = new System.Windows.Forms.Label();
            this.txtBox_Eq6_Addr2 = new System.Windows.Forms.TextBox();
            this.label199 = new System.Windows.Forms.Label();
            this.txtBox_Eq6_Addr1 = new System.Windows.Forms.TextBox();
            this.txtBox_Eq5_Addr4 = new System.Windows.Forms.TextBox();
            this.label200 = new System.Windows.Forms.Label();
            this.txtBox_Eq5_Addr3 = new System.Windows.Forms.TextBox();
            this.label201 = new System.Windows.Forms.Label();
            this.txtBox_Eq5_Addr2 = new System.Windows.Forms.TextBox();
            this.label202 = new System.Windows.Forms.Label();
            this.txtBox_Eq5_Addr1 = new System.Windows.Forms.TextBox();
            this.btn_Eq1_Change = new System.Windows.Forms.Button();
            this.btn_Eq1_Save = new System.Windows.Forms.Button();
            this.btn_Eq2_Save = new System.Windows.Forms.Button();
            this.btn_Eq2_Change = new System.Windows.Forms.Button();
            this.btn_Eq4_Save = new System.Windows.Forms.Button();
            this.btn_Eq4_Change = new System.Windows.Forms.Button();
            this.btn_Eq3_Save = new System.Windows.Forms.Button();
            this.btn_Eq3_Change = new System.Windows.Forms.Button();
            this.btn_Eq6_Save = new System.Windows.Forms.Button();
            this.btn_Eq6_Change = new System.Windows.Forms.Button();
            this.btn_Eq5_Save = new System.Windows.Forms.Button();
            this.btn_Eq5_Change = new System.Windows.Forms.Button();
            this.label203 = new System.Windows.Forms.Label();
            this.checkBoxAllSelect = new System.Windows.Forms.CheckBox();
            this.TabControl1.SuspendLayout();
            this.tabPage_CS_01.SuspendLayout();
            this.tabPage_CS_S01.SuspendLayout();
            this.tabPage_CS_S02.SuspendLayout();
            this.tabPage_CS_S03.SuspendLayout();
            this.tabPage_CS_S04.SuspendLayout();
            this.tabPage_CS_S05.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Start.ForeColor = System.Drawing.Color.Lime;
            this.btn_Start.Location = new System.Drawing.Point(12, 560);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "전송 시작";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(93, 560);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "취소";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Displaytimer
            // 
            this.Displaytimer.Interval = 500;
            this.Displaytimer.Tick += new System.EventHandler(this.Displaytimer_Tick);
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Mode.ForeColor = System.Drawing.Color.White;
            this.label_Mode.Location = new System.Drawing.Point(10, 595);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(19, 12);
            this.label_Mode.TabIndex = 7;
            this.label_Mode.Text = "--";
            // 
            // label_Ctrl
            // 
            this.label_Ctrl.AutoSize = true;
            this.label_Ctrl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Ctrl.ForeColor = System.Drawing.Color.White;
            this.label_Ctrl.Location = new System.Drawing.Point(10, 619);
            this.label_Ctrl.Name = "label_Ctrl";
            this.label_Ctrl.Size = new System.Drawing.Size(19, 12);
            this.label_Ctrl.TabIndex = 8;
            this.label_Ctrl.Text = "--";
            // 
            // label_Sts
            // 
            this.label_Sts.AutoSize = true;
            this.label_Sts.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sts.ForeColor = System.Drawing.Color.White;
            this.label_Sts.Location = new System.Drawing.Point(10, 643);
            this.label_Sts.Name = "label_Sts";
            this.label_Sts.Size = new System.Drawing.Size(19, 12);
            this.label_Sts.TabIndex = 9;
            this.label_Sts.Text = "--";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(407, 576);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(152, 12);
            this.label31.TabIndex = 59;
            this.label31.Text = "데이터 전송 완료 시간 : ";
            // 
            // label_dataTransferTime
            // 
            this.label_dataTransferTime.AutoSize = true;
            this.label_dataTransferTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_dataTransferTime.ForeColor = System.Drawing.Color.White;
            this.label_dataTransferTime.Location = new System.Drawing.Point(565, 576);
            this.label_dataTransferTime.Name = "label_dataTransferTime";
            this.label_dataTransferTime.Size = new System.Drawing.Size(19, 12);
            this.label_dataTransferTime.TabIndex = 60;
            this.label_dataTransferTime.Text = "--";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(698, 9);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(25, 15);
            this.label_Time.TabIndex = 62;
            this.label_Time.Text = "--";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(589, 9);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(25, 15);
            this.label_Date.TabIndex = 61;
            this.label_Date.Text = "--";
            // 
            // comboBox_Hour
            // 
            this.comboBox_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hour.FormattingEnabled = true;
            this.comboBox_Hour.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_Hour.Location = new System.Drawing.Point(12, 296);
            this.comboBox_Hour.Name = "comboBox_Hour";
            this.comboBox_Hour.Size = new System.Drawing.Size(52, 20);
            this.comboBox_Hour.TabIndex = 63;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(67, 299);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 12);
            this.label32.TabIndex = 64;
            this.label32.Text = "시";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(147, 299);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(18, 12);
            this.label33.TabIndex = 66;
            this.label33.Text = "분";
            // 
            // comboBox_Min
            // 
            this.comboBox_Min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Min.FormattingEnabled = true;
            this.comboBox_Min.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Min.Location = new System.Drawing.Point(92, 296);
            this.comboBox_Min.Name = "comboBox_Min";
            this.comboBox_Min.Size = new System.Drawing.Size(52, 20);
            this.comboBox_Min.TabIndex = 65;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(229, 299);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(18, 12);
            this.label34.TabIndex = 68;
            this.label34.Text = "초";
            // 
            // comboBox_Second
            // 
            this.comboBox_Second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Second.FormattingEnabled = true;
            this.comboBox_Second.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox_Second.Location = new System.Drawing.Point(172, 296);
            this.comboBox_Second.Name = "comboBox_Second";
            this.comboBox_Second.Size = new System.Drawing.Size(52, 20);
            this.comboBox_Second.TabIndex = 67;
            // 
            // checkBox_TimeSet
            // 
            this.checkBox_TimeSet.AutoSize = true;
            this.checkBox_TimeSet.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_TimeSet.ForeColor = System.Drawing.Color.White;
            this.checkBox_TimeSet.Location = new System.Drawing.Point(12, 271);
            this.checkBox_TimeSet.Name = "checkBox_TimeSet";
            this.checkBox_TimeSet.Size = new System.Drawing.Size(143, 16);
            this.checkBox_TimeSet.TabIndex = 70;
            this.checkBox_TimeSet.Text = "전송 시간 예약 설정";
            this.checkBox_TimeSet.UseVisualStyleBackColor = true;
            this.checkBox_TimeSet.Click += new System.EventHandler(this.checkBox_TimeSet_Click);
            this.checkBox_TimeSet.MouseLeave += new System.EventHandler(this.checkBox_TimeSet_MouseLeave);
            this.checkBox_TimeSet.MouseHover += new System.EventHandler(this.checkBox_TimeSet_MouseHover);
            // 
            // checkBox_CS_01
            // 
            this.checkBox_CS_01.AutoSize = true;
            this.checkBox_CS_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_01.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_01.Location = new System.Drawing.Point(12, 363);
            this.checkBox_CS_01.Name = "checkBox_CS_01";
            this.checkBox_CS_01.Size = new System.Drawing.Size(64, 16);
            this.checkBox_CS_01.TabIndex = 89;
            this.checkBox_CS_01.Text = "CS-01";
            this.checkBox_CS_01.UseVisualStyleBackColor = true;
            this.checkBox_CS_01.Click += new System.EventHandler(this.checkBox_CS_01_Click);
            // 
            // checkBox_CS_S01
            // 
            this.checkBox_CS_S01.AutoSize = true;
            this.checkBox_CS_S01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_S01.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_S01.Location = new System.Drawing.Point(12, 395);
            this.checkBox_CS_S01.Name = "checkBox_CS_S01";
            this.checkBox_CS_S01.Size = new System.Drawing.Size(73, 16);
            this.checkBox_CS_S01.TabIndex = 90;
            this.checkBox_CS_S01.Text = "CS-S01";
            this.checkBox_CS_S01.UseVisualStyleBackColor = true;
            this.checkBox_CS_S01.Click += new System.EventHandler(this.checkBox_CS_S01_Click);
            // 
            // checkBox_CS_S03
            // 
            this.checkBox_CS_S03.AutoSize = true;
            this.checkBox_CS_S03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_S03.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_S03.Location = new System.Drawing.Point(12, 459);
            this.checkBox_CS_S03.Name = "checkBox_CS_S03";
            this.checkBox_CS_S03.Size = new System.Drawing.Size(73, 16);
            this.checkBox_CS_S03.TabIndex = 92;
            this.checkBox_CS_S03.Text = "CS-S03";
            this.checkBox_CS_S03.UseVisualStyleBackColor = true;
            this.checkBox_CS_S03.Click += new System.EventHandler(this.checkBox_CS_S03_Click);
            // 
            // checkBox_CS_S02
            // 
            this.checkBox_CS_S02.AutoSize = true;
            this.checkBox_CS_S02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_S02.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_S02.Location = new System.Drawing.Point(12, 427);
            this.checkBox_CS_S02.Name = "checkBox_CS_S02";
            this.checkBox_CS_S02.Size = new System.Drawing.Size(73, 16);
            this.checkBox_CS_S02.TabIndex = 91;
            this.checkBox_CS_S02.Text = "CS-S02";
            this.checkBox_CS_S02.UseVisualStyleBackColor = true;
            this.checkBox_CS_S02.Click += new System.EventHandler(this.checkBox_CS_S02_Click);
            // 
            // checkBox_CS_S05
            // 
            this.checkBox_CS_S05.AutoSize = true;
            this.checkBox_CS_S05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_S05.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_S05.Location = new System.Drawing.Point(12, 523);
            this.checkBox_CS_S05.Name = "checkBox_CS_S05";
            this.checkBox_CS_S05.Size = new System.Drawing.Size(73, 16);
            this.checkBox_CS_S05.TabIndex = 94;
            this.checkBox_CS_S05.Text = "CS-S05";
            this.checkBox_CS_S05.UseVisualStyleBackColor = true;
            this.checkBox_CS_S05.Click += new System.EventHandler(this.checkBox_CS_S05_Click);
            // 
            // checkBox_CS_S04
            // 
            this.checkBox_CS_S04.AutoSize = true;
            this.checkBox_CS_S04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_CS_S04.ForeColor = System.Drawing.Color.White;
            this.checkBox_CS_S04.Location = new System.Drawing.Point(12, 491);
            this.checkBox_CS_S04.Name = "checkBox_CS_S04";
            this.checkBox_CS_S04.Size = new System.Drawing.Size(73, 16);
            this.checkBox_CS_S04.TabIndex = 93;
            this.checkBox_CS_S04.Text = "CS-S04";
            this.checkBox_CS_S04.UseVisualStyleBackColor = true;
            this.checkBox_CS_S04.Click += new System.EventHandler(this.checkBox_CS_S04_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl1.Controls.Add(this.tabPage_CS_01);
            this.TabControl1.Controls.Add(this.tabPage_CS_S01);
            this.TabControl1.Controls.Add(this.tabPage_CS_S02);
            this.TabControl1.Controls.Add(this.tabPage_CS_S03);
            this.TabControl1.Controls.Add(this.tabPage_CS_S04);
            this.TabControl1.Controls.Add(this.tabPage_CS_S05);
            this.TabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.TabControl1.Location = new System.Drawing.Point(409, 97);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(366, 456);
            this.TabControl1.TabIndex = 95;
            // 
            // tabPage_CS_01
            // 
            this.tabPage_CS_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_01.Controls.Add(this.label16);
            this.tabPage_CS_01.Controls.Add(this.label17);
            this.tabPage_CS_01.Controls.Add(this.label19);
            this.tabPage_CS_01.Controls.Add(this.label20);
            this.tabPage_CS_01.Controls.Add(this.label22);
            this.tabPage_CS_01.Controls.Add(this.label23);
            this.tabPage_CS_01.Controls.Add(this.label25);
            this.tabPage_CS_01.Controls.Add(this.label26);
            this.tabPage_CS_01.Controls.Add(this.label28);
            this.tabPage_CS_01.Controls.Add(this.label29);
            this.tabPage_CS_01.Controls.Add(this.label13);
            this.tabPage_CS_01.Controls.Add(this.label14);
            this.tabPage_CS_01.Controls.Add(this.label10);
            this.tabPage_CS_01.Controls.Add(this.label11);
            this.tabPage_CS_01.Controls.Add(this.label6);
            this.tabPage_CS_01.Controls.Add(this.label8);
            this.tabPage_CS_01.Controls.Add(this.label2);
            this.tabPage_CS_01.Controls.Add(this.label5);
            this.tabPage_CS_01.Controls.Add(this.label27);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_SUSCarrierLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_SUSCarrierRight);
            this.tabPage_CS_01.Controls.Add(this.label30);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_SUSScanLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_SUSScanRight);
            this.tabPage_CS_01.Controls.Add(this.label21);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU2CarrierLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU2CarrierRight);
            this.tabPage_CS_01.Controls.Add(this.label24);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU2ScanLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU2ScanRight);
            this.tabPage_CS_01.Controls.Add(this.label15);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU1CarrierLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU1CarrierRight);
            this.tabPage_CS_01.Controls.Add(this.label18);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU1ScanLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_CU1ScanRight);
            this.tabPage_CS_01.Controls.Add(this.label9);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF2UpLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF2UpRight);
            this.tabPage_CS_01.Controls.Add(this.label12);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF2DownLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF2DownRight);
            this.tabPage_CS_01.Controls.Add(this.label7);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF1UpLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF1UpRight);
            this.tabPage_CS_01.Controls.Add(this.label4);
            this.tabPage_CS_01.Controls.Add(this.label3);
            this.tabPage_CS_01.Controls.Add(this.label1);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF1DownLeft);
            this.tabPage_CS_01.Controls.Add(this.textBox_CS01_BF1DownRight);
            this.tabPage_CS_01.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_01.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_CS_01.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_01.Name = "tabPage_CS_01";
            this.tabPage_CS_01.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CS_01.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_01.TabIndex = 0;
            this.tabPage_CS_01.Text = "CS-01";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(186, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 188;
            this.label16.Text = "Left";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(186, 369);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 187;
            this.label17.Text = "Right";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(186, 313);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 186;
            this.label19.Text = "Left";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(186, 286);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 12);
            this.label20.TabIndex = 185;
            this.label20.Text = "Right";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(186, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 184;
            this.label22.Text = "Left";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(186, 203);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 12);
            this.label23.TabIndex = 183;
            this.label23.Text = "Right";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(186, 147);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 182;
            this.label25.Text = "Left";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(186, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 12);
            this.label26.TabIndex = 181;
            this.label26.Text = "Right";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(186, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 180;
            this.label28.Text = "Left";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(186, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 12);
            this.label29.TabIndex = 179;
            this.label29.Text = "Right";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(32, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 178;
            this.label13.Text = "Left";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 12);
            this.label14.TabIndex = 177;
            this.label14.Text = "Right";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 176;
            this.label10.Text = "Left";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 175;
            this.label11.Text = "Right";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 174;
            this.label6.Text = "Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 173;
            this.label8.Text = "Right";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 172;
            this.label2.Text = "Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 171;
            this.label5.Text = "Right";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(225, 349);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 12);
            this.label27.TabIndex = 170;
            this.label27.Text = "SUS_Carrier";
            // 
            // textBox_CS01_SUSCarrierLeft
            // 
            this.textBox_CS01_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CS01_SUSCarrierLeft.Name = "textBox_CS01_SUSCarrierLeft";
            this.textBox_CS01_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CS01_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CS01_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_SUSCarrierRight
            // 
            this.textBox_CS01_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CS01_SUSCarrierRight.Name = "textBox_CS01_SUSCarrierRight";
            this.textBox_CS01_SUSCarrierRight.ReadOnly = true;
            this.textBox_CS01_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_SUSCarrierRight.TabIndex = 168;
            this.textBox_CS01_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(71, 349);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 12);
            this.label30.TabIndex = 167;
            this.label30.Text = "SUS_Scan";
            // 
            // textBox_CS01_SUSScanLeft
            // 
            this.textBox_CS01_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CS01_SUSScanLeft.Name = "textBox_CS01_SUSScanLeft";
            this.textBox_CS01_SUSScanLeft.ReadOnly = true;
            this.textBox_CS01_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_SUSScanLeft.TabIndex = 166;
            this.textBox_CS01_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_SUSScanRight
            // 
            this.textBox_CS01_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CS01_SUSScanRight.Name = "textBox_CS01_SUSScanRight";
            this.textBox_CS01_SUSScanRight.ReadOnly = true;
            this.textBox_CS01_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_SUSScanRight.TabIndex = 165;
            this.textBox_CS01_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(225, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 164;
            this.label21.Text = "CU2_Carrier";
            // 
            // textBox_CS01_CU2CarrierLeft
            // 
            this.textBox_CS01_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CS01_CU2CarrierLeft.Name = "textBox_CS01_CU2CarrierLeft";
            this.textBox_CS01_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CS01_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CS01_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_CU2CarrierRight
            // 
            this.textBox_CS01_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CS01_CU2CarrierRight.Name = "textBox_CS01_CU2CarrierRight";
            this.textBox_CS01_CU2CarrierRight.ReadOnly = true;
            this.textBox_CS01_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU2CarrierRight.TabIndex = 162;
            this.textBox_CS01_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(71, 266);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 161;
            this.label24.Text = "CU2_Scan";
            // 
            // textBox_CS01_CU2ScanLeft
            // 
            this.textBox_CS01_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CS01_CU2ScanLeft.Name = "textBox_CS01_CU2ScanLeft";
            this.textBox_CS01_CU2ScanLeft.ReadOnly = true;
            this.textBox_CS01_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU2ScanLeft.TabIndex = 160;
            this.textBox_CS01_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_CU2ScanRight
            // 
            this.textBox_CS01_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CS01_CU2ScanRight.Name = "textBox_CS01_CU2ScanRight";
            this.textBox_CS01_CU2ScanRight.ReadOnly = true;
            this.textBox_CS01_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU2ScanRight.TabIndex = 159;
            this.textBox_CS01_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(225, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 158;
            this.label15.Text = "CU1_Carrier";
            // 
            // textBox_CS01_CU1CarrierLeft
            // 
            this.textBox_CS01_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CS01_CU1CarrierLeft.Name = "textBox_CS01_CU1CarrierLeft";
            this.textBox_CS01_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CS01_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CS01_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_CU1CarrierRight
            // 
            this.textBox_CS01_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CS01_CU1CarrierRight.Name = "textBox_CS01_CU1CarrierRight";
            this.textBox_CS01_CU1CarrierRight.ReadOnly = true;
            this.textBox_CS01_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU1CarrierRight.TabIndex = 156;
            this.textBox_CS01_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(71, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 155;
            this.label18.Text = "CU1_Scan";
            // 
            // textBox_CS01_CU1ScanLeft
            // 
            this.textBox_CS01_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CS01_CU1ScanLeft.Name = "textBox_CS01_CU1ScanLeft";
            this.textBox_CS01_CU1ScanLeft.ReadOnly = true;
            this.textBox_CS01_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU1ScanLeft.TabIndex = 154;
            this.textBox_CS01_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_CU1ScanRight
            // 
            this.textBox_CS01_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CS01_CU1ScanRight.Name = "textBox_CS01_CU1ScanRight";
            this.textBox_CS01_CU1ScanRight.ReadOnly = true;
            this.textBox_CS01_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_CU1ScanRight.TabIndex = 153;
            this.textBox_CS01_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(225, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 152;
            this.label9.Text = "BF2_Up";
            // 
            // textBox_CS01_BF2UpLeft
            // 
            this.textBox_CS01_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CS01_BF2UpLeft.Name = "textBox_CS01_BF2UpLeft";
            this.textBox_CS01_BF2UpLeft.ReadOnly = true;
            this.textBox_CS01_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF2UpLeft.TabIndex = 151;
            this.textBox_CS01_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_BF2UpRight
            // 
            this.textBox_CS01_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CS01_BF2UpRight.Name = "textBox_CS01_BF2UpRight";
            this.textBox_CS01_BF2UpRight.ReadOnly = true;
            this.textBox_CS01_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF2UpRight.TabIndex = 150;
            this.textBox_CS01_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(71, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 12);
            this.label12.TabIndex = 149;
            this.label12.Text = "BF2_Down";
            // 
            // textBox_CS01_BF2DownLeft
            // 
            this.textBox_CS01_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CS01_BF2DownLeft.Name = "textBox_CS01_BF2DownLeft";
            this.textBox_CS01_BF2DownLeft.ReadOnly = true;
            this.textBox_CS01_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF2DownLeft.TabIndex = 148;
            this.textBox_CS01_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_BF2DownRight
            // 
            this.textBox_CS01_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CS01_BF2DownRight.Name = "textBox_CS01_BF2DownRight";
            this.textBox_CS01_BF2DownRight.ReadOnly = true;
            this.textBox_CS01_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF2DownRight.TabIndex = 147;
            this.textBox_CS01_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(225, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 146;
            this.label7.Text = "BF1_Up";
            // 
            // textBox_CS01_BF1UpLeft
            // 
            this.textBox_CS01_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CS01_BF1UpLeft.Name = "textBox_CS01_BF1UpLeft";
            this.textBox_CS01_BF1UpLeft.ReadOnly = true;
            this.textBox_CS01_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF1UpLeft.TabIndex = 145;
            this.textBox_CS01_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_BF1UpRight
            // 
            this.textBox_CS01_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CS01_BF1UpRight.Name = "textBox_CS01_BF1UpRight";
            this.textBox_CS01_BF1UpRight.ReadOnly = true;
            this.textBox_CS01_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF1UpRight.TabIndex = 144;
            this.textBox_CS01_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 143;
            this.label4.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 142;
            this.label3.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 141;
            this.label1.Text = "BF1_Down";
            // 
            // textBox_CS01_BF1DownLeft
            // 
            this.textBox_CS01_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CS01_BF1DownLeft.Name = "textBox_CS01_BF1DownLeft";
            this.textBox_CS01_BF1DownLeft.ReadOnly = true;
            this.textBox_CS01_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF1DownLeft.TabIndex = 140;
            this.textBox_CS01_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CS01_BF1DownRight
            // 
            this.textBox_CS01_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CS01_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CS01_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CS01_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CS01_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CS01_BF1DownRight.Name = "textBox_CS01_BF1DownRight";
            this.textBox_CS01_BF1DownRight.ReadOnly = true;
            this.textBox_CS01_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CS01_BF1DownRight.TabIndex = 139;
            this.textBox_CS01_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_CS_S01
            // 
            this.tabPage_CS_S01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_S01.Controls.Add(this.label35);
            this.tabPage_CS_S01.Controls.Add(this.label36);
            this.tabPage_CS_S01.Controls.Add(this.label37);
            this.tabPage_CS_S01.Controls.Add(this.label38);
            this.tabPage_CS_S01.Controls.Add(this.label39);
            this.tabPage_CS_S01.Controls.Add(this.label40);
            this.tabPage_CS_S01.Controls.Add(this.label41);
            this.tabPage_CS_S01.Controls.Add(this.label42);
            this.tabPage_CS_S01.Controls.Add(this.label43);
            this.tabPage_CS_S01.Controls.Add(this.label44);
            this.tabPage_CS_S01.Controls.Add(this.label45);
            this.tabPage_CS_S01.Controls.Add(this.label46);
            this.tabPage_CS_S01.Controls.Add(this.label47);
            this.tabPage_CS_S01.Controls.Add(this.label48);
            this.tabPage_CS_S01.Controls.Add(this.label49);
            this.tabPage_CS_S01.Controls.Add(this.label50);
            this.tabPage_CS_S01.Controls.Add(this.label51);
            this.tabPage_CS_S01.Controls.Add(this.label52);
            this.tabPage_CS_S01.Controls.Add(this.label53);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_SUSCarrierLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_SUSCarrierRight);
            this.tabPage_CS_S01.Controls.Add(this.label54);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_SUSScanLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_SUSScanRight);
            this.tabPage_CS_S01.Controls.Add(this.label55);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU2CarrierLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU2CarrierRight);
            this.tabPage_CS_S01.Controls.Add(this.label56);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU2ScanLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU2ScanRight);
            this.tabPage_CS_S01.Controls.Add(this.label57);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU1CarrierLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU1CarrierRight);
            this.tabPage_CS_S01.Controls.Add(this.label58);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU1ScanLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_CU1ScanRight);
            this.tabPage_CS_S01.Controls.Add(this.label59);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF2UpLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF2UpRight);
            this.tabPage_CS_S01.Controls.Add(this.label60);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF2DownLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF2DownRight);
            this.tabPage_CS_S01.Controls.Add(this.label61);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF1UpLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF1UpRight);
            this.tabPage_CS_S01.Controls.Add(this.label62);
            this.tabPage_CS_S01.Controls.Add(this.label63);
            this.tabPage_CS_S01.Controls.Add(this.label64);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF1DownLeft);
            this.tabPage_CS_S01.Controls.Add(this.textBox_CSS01_BF1DownRight);
            this.tabPage_CS_S01.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_S01.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_S01.Name = "tabPage_CS_S01";
            this.tabPage_CS_S01.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CS_S01.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_S01.TabIndex = 1;
            this.tabPage_CS_S01.Text = "CS-S01";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(186, 396);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 12);
            this.label35.TabIndex = 188;
            this.label35.Text = "Left";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(186, 369);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 12);
            this.label36.TabIndex = 187;
            this.label36.Text = "Right";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(186, 313);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 186;
            this.label37.Text = "Left";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(186, 286);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 12);
            this.label38.TabIndex = 185;
            this.label38.Text = "Right";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(186, 230);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 12);
            this.label39.TabIndex = 184;
            this.label39.Text = "Left";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(186, 203);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(38, 12);
            this.label40.TabIndex = 183;
            this.label40.Text = "Right";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(186, 147);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 12);
            this.label41.TabIndex = 182;
            this.label41.Text = "Left";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(186, 120);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(38, 12);
            this.label42.TabIndex = 181;
            this.label42.Text = "Right";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(186, 64);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 12);
            this.label43.TabIndex = 180;
            this.label43.Text = "Left";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(186, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(38, 12);
            this.label44.TabIndex = 179;
            this.label44.Text = "Right";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(32, 396);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 12);
            this.label45.TabIndex = 178;
            this.label45.Text = "Left";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(32, 369);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(38, 12);
            this.label46.TabIndex = 177;
            this.label46.Text = "Right";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(32, 313);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 12);
            this.label47.TabIndex = 176;
            this.label47.Text = "Left";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(32, 286);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(38, 12);
            this.label48.TabIndex = 175;
            this.label48.Text = "Right";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(32, 230);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(29, 12);
            this.label49.TabIndex = 174;
            this.label49.Text = "Left";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(32, 203);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(38, 12);
            this.label50.TabIndex = 173;
            this.label50.Text = "Right";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(32, 147);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 12);
            this.label51.TabIndex = 172;
            this.label51.Text = "Left";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(32, 120);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(38, 12);
            this.label52.TabIndex = 171;
            this.label52.Text = "Right";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(225, 349);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(84, 12);
            this.label53.TabIndex = 170;
            this.label53.Text = "SUS_Carrier";
            // 
            // textBox_CSS01_SUSCarrierLeft
            // 
            this.textBox_CSS01_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CSS01_SUSCarrierLeft.Name = "textBox_CSS01_SUSCarrierLeft";
            this.textBox_CSS01_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CSS01_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CSS01_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_SUSCarrierRight
            // 
            this.textBox_CSS01_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CSS01_SUSCarrierRight.Name = "textBox_CSS01_SUSCarrierRight";
            this.textBox_CSS01_SUSCarrierRight.ReadOnly = true;
            this.textBox_CSS01_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_SUSCarrierRight.TabIndex = 168;
            this.textBox_CSS01_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(71, 349);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(72, 12);
            this.label54.TabIndex = 167;
            this.label54.Text = "SUS_Scan";
            // 
            // textBox_CSS01_SUSScanLeft
            // 
            this.textBox_CSS01_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CSS01_SUSScanLeft.Name = "textBox_CSS01_SUSScanLeft";
            this.textBox_CSS01_SUSScanLeft.ReadOnly = true;
            this.textBox_CSS01_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_SUSScanLeft.TabIndex = 166;
            this.textBox_CSS01_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_SUSScanRight
            // 
            this.textBox_CSS01_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CSS01_SUSScanRight.Name = "textBox_CSS01_SUSScanRight";
            this.textBox_CSS01_SUSScanRight.ReadOnly = true;
            this.textBox_CSS01_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_SUSScanRight.TabIndex = 165;
            this.textBox_CSS01_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(225, 266);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(83, 12);
            this.label55.TabIndex = 164;
            this.label55.Text = "CU2_Carrier";
            // 
            // textBox_CSS01_CU2CarrierLeft
            // 
            this.textBox_CSS01_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CSS01_CU2CarrierLeft.Name = "textBox_CSS01_CU2CarrierLeft";
            this.textBox_CSS01_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CSS01_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CSS01_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_CU2CarrierRight
            // 
            this.textBox_CSS01_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CSS01_CU2CarrierRight.Name = "textBox_CSS01_CU2CarrierRight";
            this.textBox_CSS01_CU2CarrierRight.ReadOnly = true;
            this.textBox_CSS01_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU2CarrierRight.TabIndex = 162;
            this.textBox_CSS01_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(71, 266);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(71, 12);
            this.label56.TabIndex = 161;
            this.label56.Text = "CU2_Scan";
            // 
            // textBox_CSS01_CU2ScanLeft
            // 
            this.textBox_CSS01_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CSS01_CU2ScanLeft.Name = "textBox_CSS01_CU2ScanLeft";
            this.textBox_CSS01_CU2ScanLeft.ReadOnly = true;
            this.textBox_CSS01_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU2ScanLeft.TabIndex = 160;
            this.textBox_CSS01_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_CU2ScanRight
            // 
            this.textBox_CSS01_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CSS01_CU2ScanRight.Name = "textBox_CSS01_CU2ScanRight";
            this.textBox_CSS01_CU2ScanRight.ReadOnly = true;
            this.textBox_CSS01_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU2ScanRight.TabIndex = 159;
            this.textBox_CSS01_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(225, 183);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 12);
            this.label57.TabIndex = 158;
            this.label57.Text = "CU1_Carrier";
            // 
            // textBox_CSS01_CU1CarrierLeft
            // 
            this.textBox_CSS01_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CSS01_CU1CarrierLeft.Name = "textBox_CSS01_CU1CarrierLeft";
            this.textBox_CSS01_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CSS01_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CSS01_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_CU1CarrierRight
            // 
            this.textBox_CSS01_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CSS01_CU1CarrierRight.Name = "textBox_CSS01_CU1CarrierRight";
            this.textBox_CSS01_CU1CarrierRight.ReadOnly = true;
            this.textBox_CSS01_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU1CarrierRight.TabIndex = 156;
            this.textBox_CSS01_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(71, 183);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(71, 12);
            this.label58.TabIndex = 155;
            this.label58.Text = "CU1_Scan";
            // 
            // textBox_CSS01_CU1ScanLeft
            // 
            this.textBox_CSS01_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CSS01_CU1ScanLeft.Name = "textBox_CSS01_CU1ScanLeft";
            this.textBox_CSS01_CU1ScanLeft.ReadOnly = true;
            this.textBox_CSS01_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU1ScanLeft.TabIndex = 154;
            this.textBox_CSS01_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_CU1ScanRight
            // 
            this.textBox_CSS01_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CSS01_CU1ScanRight.Name = "textBox_CSS01_CU1ScanRight";
            this.textBox_CSS01_CU1ScanRight.ReadOnly = true;
            this.textBox_CSS01_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_CU1ScanRight.TabIndex = 153;
            this.textBox_CSS01_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(225, 100);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 12);
            this.label59.TabIndex = 152;
            this.label59.Text = "BF2_Up";
            // 
            // textBox_CSS01_BF2UpLeft
            // 
            this.textBox_CSS01_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CSS01_BF2UpLeft.Name = "textBox_CSS01_BF2UpLeft";
            this.textBox_CSS01_BF2UpLeft.ReadOnly = true;
            this.textBox_CSS01_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF2UpLeft.TabIndex = 151;
            this.textBox_CSS01_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_BF2UpRight
            // 
            this.textBox_CSS01_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CSS01_BF2UpRight.Name = "textBox_CSS01_BF2UpRight";
            this.textBox_CSS01_BF2UpRight.ReadOnly = true;
            this.textBox_CSS01_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF2UpRight.TabIndex = 150;
            this.textBox_CSS01_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(71, 100);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 12);
            this.label60.TabIndex = 149;
            this.label60.Text = "BF2_Down";
            // 
            // textBox_CSS01_BF2DownLeft
            // 
            this.textBox_CSS01_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CSS01_BF2DownLeft.Name = "textBox_CSS01_BF2DownLeft";
            this.textBox_CSS01_BF2DownLeft.ReadOnly = true;
            this.textBox_CSS01_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF2DownLeft.TabIndex = 148;
            this.textBox_CSS01_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_BF2DownRight
            // 
            this.textBox_CSS01_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CSS01_BF2DownRight.Name = "textBox_CSS01_BF2DownRight";
            this.textBox_CSS01_BF2DownRight.ReadOnly = true;
            this.textBox_CSS01_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF2DownRight.TabIndex = 147;
            this.textBox_CSS01_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(225, 17);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(53, 12);
            this.label61.TabIndex = 146;
            this.label61.Text = "BF1_Up";
            // 
            // textBox_CSS01_BF1UpLeft
            // 
            this.textBox_CSS01_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CSS01_BF1UpLeft.Name = "textBox_CSS01_BF1UpLeft";
            this.textBox_CSS01_BF1UpLeft.ReadOnly = true;
            this.textBox_CSS01_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF1UpLeft.TabIndex = 145;
            this.textBox_CSS01_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_BF1UpRight
            // 
            this.textBox_CSS01_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CSS01_BF1UpRight.Name = "textBox_CSS01_BF1UpRight";
            this.textBox_CSS01_BF1UpRight.ReadOnly = true;
            this.textBox_CSS01_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF1UpRight.TabIndex = 144;
            this.textBox_CSS01_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(32, 64);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(29, 12);
            this.label62.TabIndex = 143;
            this.label62.Text = "Left";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(32, 37);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(38, 12);
            this.label63.TabIndex = 142;
            this.label63.Text = "Right";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(71, 17);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(72, 12);
            this.label64.TabIndex = 141;
            this.label64.Text = "BF1_Down";
            // 
            // textBox_CSS01_BF1DownLeft
            // 
            this.textBox_CSS01_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CSS01_BF1DownLeft.Name = "textBox_CSS01_BF1DownLeft";
            this.textBox_CSS01_BF1DownLeft.ReadOnly = true;
            this.textBox_CSS01_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF1DownLeft.TabIndex = 140;
            this.textBox_CSS01_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS01_BF1DownRight
            // 
            this.textBox_CSS01_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS01_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS01_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS01_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS01_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CSS01_BF1DownRight.Name = "textBox_CSS01_BF1DownRight";
            this.textBox_CSS01_BF1DownRight.ReadOnly = true;
            this.textBox_CSS01_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS01_BF1DownRight.TabIndex = 139;
            this.textBox_CSS01_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_CS_S02
            // 
            this.tabPage_CS_S02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_S02.Controls.Add(this.label65);
            this.tabPage_CS_S02.Controls.Add(this.label66);
            this.tabPage_CS_S02.Controls.Add(this.label67);
            this.tabPage_CS_S02.Controls.Add(this.label68);
            this.tabPage_CS_S02.Controls.Add(this.label69);
            this.tabPage_CS_S02.Controls.Add(this.label70);
            this.tabPage_CS_S02.Controls.Add(this.label71);
            this.tabPage_CS_S02.Controls.Add(this.label72);
            this.tabPage_CS_S02.Controls.Add(this.label73);
            this.tabPage_CS_S02.Controls.Add(this.label74);
            this.tabPage_CS_S02.Controls.Add(this.label75);
            this.tabPage_CS_S02.Controls.Add(this.label76);
            this.tabPage_CS_S02.Controls.Add(this.label77);
            this.tabPage_CS_S02.Controls.Add(this.label78);
            this.tabPage_CS_S02.Controls.Add(this.label79);
            this.tabPage_CS_S02.Controls.Add(this.label80);
            this.tabPage_CS_S02.Controls.Add(this.label81);
            this.tabPage_CS_S02.Controls.Add(this.label82);
            this.tabPage_CS_S02.Controls.Add(this.label83);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_SUSCarrierLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_SUSCarrierRight);
            this.tabPage_CS_S02.Controls.Add(this.label84);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_SUSScanLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_SUSScanRight);
            this.tabPage_CS_S02.Controls.Add(this.label85);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU2CarrierLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU2CarrierRight);
            this.tabPage_CS_S02.Controls.Add(this.label86);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU2ScanLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU2ScanRight);
            this.tabPage_CS_S02.Controls.Add(this.label87);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU1CarrierLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU1CarrierRight);
            this.tabPage_CS_S02.Controls.Add(this.label88);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU1ScanLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_CU1ScanRight);
            this.tabPage_CS_S02.Controls.Add(this.label89);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF2UpLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF2UpRight);
            this.tabPage_CS_S02.Controls.Add(this.label90);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF2DownLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF2DownRight);
            this.tabPage_CS_S02.Controls.Add(this.label91);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF1UpLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF1UpRight);
            this.tabPage_CS_S02.Controls.Add(this.label92);
            this.tabPage_CS_S02.Controls.Add(this.label93);
            this.tabPage_CS_S02.Controls.Add(this.label94);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF1DownLeft);
            this.tabPage_CS_S02.Controls.Add(this.textBox_CSS02_BF1DownRight);
            this.tabPage_CS_S02.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_S02.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_S02.Name = "tabPage_CS_S02";
            this.tabPage_CS_S02.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CS_S02.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_S02.TabIndex = 2;
            this.tabPage_CS_S02.Text = "CS-S02";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(186, 396);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(29, 12);
            this.label65.TabIndex = 188;
            this.label65.Text = "Left";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(186, 369);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(38, 12);
            this.label66.TabIndex = 187;
            this.label66.Text = "Right";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(186, 313);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(29, 12);
            this.label67.TabIndex = 186;
            this.label67.Text = "Left";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(186, 286);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(38, 12);
            this.label68.TabIndex = 185;
            this.label68.Text = "Right";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(186, 230);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(29, 12);
            this.label69.TabIndex = 184;
            this.label69.Text = "Left";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(186, 203);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(38, 12);
            this.label70.TabIndex = 183;
            this.label70.Text = "Right";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(186, 147);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(29, 12);
            this.label71.TabIndex = 182;
            this.label71.Text = "Left";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(186, 120);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 12);
            this.label72.TabIndex = 181;
            this.label72.Text = "Right";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(186, 64);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(29, 12);
            this.label73.TabIndex = 180;
            this.label73.Text = "Left";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(186, 37);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(38, 12);
            this.label74.TabIndex = 179;
            this.label74.Text = "Right";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(32, 396);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(29, 12);
            this.label75.TabIndex = 178;
            this.label75.Text = "Left";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(32, 369);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(38, 12);
            this.label76.TabIndex = 177;
            this.label76.Text = "Right";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(32, 313);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(29, 12);
            this.label77.TabIndex = 176;
            this.label77.Text = "Left";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(32, 286);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(38, 12);
            this.label78.TabIndex = 175;
            this.label78.Text = "Right";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(32, 230);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(29, 12);
            this.label79.TabIndex = 174;
            this.label79.Text = "Left";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(32, 203);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(38, 12);
            this.label80.TabIndex = 173;
            this.label80.Text = "Right";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(32, 147);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(29, 12);
            this.label81.TabIndex = 172;
            this.label81.Text = "Left";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(32, 120);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(38, 12);
            this.label82.TabIndex = 171;
            this.label82.Text = "Right";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label83.ForeColor = System.Drawing.Color.White;
            this.label83.Location = new System.Drawing.Point(225, 349);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(84, 12);
            this.label83.TabIndex = 170;
            this.label83.Text = "SUS_Carrier";
            // 
            // textBox_CSS02_SUSCarrierLeft
            // 
            this.textBox_CSS02_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CSS02_SUSCarrierLeft.Name = "textBox_CSS02_SUSCarrierLeft";
            this.textBox_CSS02_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CSS02_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CSS02_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_SUSCarrierRight
            // 
            this.textBox_CSS02_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CSS02_SUSCarrierRight.Name = "textBox_CSS02_SUSCarrierRight";
            this.textBox_CSS02_SUSCarrierRight.ReadOnly = true;
            this.textBox_CSS02_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_SUSCarrierRight.TabIndex = 168;
            this.textBox_CSS02_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(71, 349);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(72, 12);
            this.label84.TabIndex = 167;
            this.label84.Text = "SUS_Scan";
            // 
            // textBox_CSS02_SUSScanLeft
            // 
            this.textBox_CSS02_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CSS02_SUSScanLeft.Name = "textBox_CSS02_SUSScanLeft";
            this.textBox_CSS02_SUSScanLeft.ReadOnly = true;
            this.textBox_CSS02_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_SUSScanLeft.TabIndex = 166;
            this.textBox_CSS02_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_SUSScanRight
            // 
            this.textBox_CSS02_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CSS02_SUSScanRight.Name = "textBox_CSS02_SUSScanRight";
            this.textBox_CSS02_SUSScanRight.ReadOnly = true;
            this.textBox_CSS02_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_SUSScanRight.TabIndex = 165;
            this.textBox_CSS02_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(225, 266);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(83, 12);
            this.label85.TabIndex = 164;
            this.label85.Text = "CU2_Carrier";
            // 
            // textBox_CSS02_CU2CarrierLeft
            // 
            this.textBox_CSS02_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CSS02_CU2CarrierLeft.Name = "textBox_CSS02_CU2CarrierLeft";
            this.textBox_CSS02_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CSS02_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CSS02_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_CU2CarrierRight
            // 
            this.textBox_CSS02_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CSS02_CU2CarrierRight.Name = "textBox_CSS02_CU2CarrierRight";
            this.textBox_CSS02_CU2CarrierRight.ReadOnly = true;
            this.textBox_CSS02_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU2CarrierRight.TabIndex = 162;
            this.textBox_CSS02_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(71, 266);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(71, 12);
            this.label86.TabIndex = 161;
            this.label86.Text = "CU2_Scan";
            // 
            // textBox_CSS02_CU2ScanLeft
            // 
            this.textBox_CSS02_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CSS02_CU2ScanLeft.Name = "textBox_CSS02_CU2ScanLeft";
            this.textBox_CSS02_CU2ScanLeft.ReadOnly = true;
            this.textBox_CSS02_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU2ScanLeft.TabIndex = 160;
            this.textBox_CSS02_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_CU2ScanRight
            // 
            this.textBox_CSS02_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CSS02_CU2ScanRight.Name = "textBox_CSS02_CU2ScanRight";
            this.textBox_CSS02_CU2ScanRight.ReadOnly = true;
            this.textBox_CSS02_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU2ScanRight.TabIndex = 159;
            this.textBox_CSS02_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(225, 183);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(83, 12);
            this.label87.TabIndex = 158;
            this.label87.Text = "CU1_Carrier";
            // 
            // textBox_CSS02_CU1CarrierLeft
            // 
            this.textBox_CSS02_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CSS02_CU1CarrierLeft.Name = "textBox_CSS02_CU1CarrierLeft";
            this.textBox_CSS02_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CSS02_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CSS02_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_CU1CarrierRight
            // 
            this.textBox_CSS02_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CSS02_CU1CarrierRight.Name = "textBox_CSS02_CU1CarrierRight";
            this.textBox_CSS02_CU1CarrierRight.ReadOnly = true;
            this.textBox_CSS02_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU1CarrierRight.TabIndex = 156;
            this.textBox_CSS02_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(71, 183);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(71, 12);
            this.label88.TabIndex = 155;
            this.label88.Text = "CU1_Scan";
            // 
            // textBox_CSS02_CU1ScanLeft
            // 
            this.textBox_CSS02_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CSS02_CU1ScanLeft.Name = "textBox_CSS02_CU1ScanLeft";
            this.textBox_CSS02_CU1ScanLeft.ReadOnly = true;
            this.textBox_CSS02_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU1ScanLeft.TabIndex = 154;
            this.textBox_CSS02_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_CU1ScanRight
            // 
            this.textBox_CSS02_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CSS02_CU1ScanRight.Name = "textBox_CSS02_CU1ScanRight";
            this.textBox_CSS02_CU1ScanRight.ReadOnly = true;
            this.textBox_CSS02_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_CU1ScanRight.TabIndex = 153;
            this.textBox_CSS02_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(225, 100);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 12);
            this.label89.TabIndex = 152;
            this.label89.Text = "BF2_Up";
            // 
            // textBox_CSS02_BF2UpLeft
            // 
            this.textBox_CSS02_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CSS02_BF2UpLeft.Name = "textBox_CSS02_BF2UpLeft";
            this.textBox_CSS02_BF2UpLeft.ReadOnly = true;
            this.textBox_CSS02_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF2UpLeft.TabIndex = 151;
            this.textBox_CSS02_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_BF2UpRight
            // 
            this.textBox_CSS02_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CSS02_BF2UpRight.Name = "textBox_CSS02_BF2UpRight";
            this.textBox_CSS02_BF2UpRight.ReadOnly = true;
            this.textBox_CSS02_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF2UpRight.TabIndex = 150;
            this.textBox_CSS02_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(71, 100);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(72, 12);
            this.label90.TabIndex = 149;
            this.label90.Text = "BF2_Down";
            // 
            // textBox_CSS02_BF2DownLeft
            // 
            this.textBox_CSS02_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CSS02_BF2DownLeft.Name = "textBox_CSS02_BF2DownLeft";
            this.textBox_CSS02_BF2DownLeft.ReadOnly = true;
            this.textBox_CSS02_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF2DownLeft.TabIndex = 148;
            this.textBox_CSS02_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_BF2DownRight
            // 
            this.textBox_CSS02_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CSS02_BF2DownRight.Name = "textBox_CSS02_BF2DownRight";
            this.textBox_CSS02_BF2DownRight.ReadOnly = true;
            this.textBox_CSS02_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF2DownRight.TabIndex = 147;
            this.textBox_CSS02_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label91.ForeColor = System.Drawing.Color.White;
            this.label91.Location = new System.Drawing.Point(225, 17);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(53, 12);
            this.label91.TabIndex = 146;
            this.label91.Text = "BF1_Up";
            // 
            // textBox_CSS02_BF1UpLeft
            // 
            this.textBox_CSS02_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CSS02_BF1UpLeft.Name = "textBox_CSS02_BF1UpLeft";
            this.textBox_CSS02_BF1UpLeft.ReadOnly = true;
            this.textBox_CSS02_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF1UpLeft.TabIndex = 145;
            this.textBox_CSS02_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_BF1UpRight
            // 
            this.textBox_CSS02_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CSS02_BF1UpRight.Name = "textBox_CSS02_BF1UpRight";
            this.textBox_CSS02_BF1UpRight.ReadOnly = true;
            this.textBox_CSS02_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF1UpRight.TabIndex = 144;
            this.textBox_CSS02_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label92.ForeColor = System.Drawing.Color.White;
            this.label92.Location = new System.Drawing.Point(32, 64);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(29, 12);
            this.label92.TabIndex = 143;
            this.label92.Text = "Left";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label93.ForeColor = System.Drawing.Color.White;
            this.label93.Location = new System.Drawing.Point(32, 37);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(38, 12);
            this.label93.TabIndex = 142;
            this.label93.Text = "Right";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label94.ForeColor = System.Drawing.Color.White;
            this.label94.Location = new System.Drawing.Point(71, 17);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(72, 12);
            this.label94.TabIndex = 141;
            this.label94.Text = "BF1_Down";
            // 
            // textBox_CSS02_BF1DownLeft
            // 
            this.textBox_CSS02_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CSS02_BF1DownLeft.Name = "textBox_CSS02_BF1DownLeft";
            this.textBox_CSS02_BF1DownLeft.ReadOnly = true;
            this.textBox_CSS02_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF1DownLeft.TabIndex = 140;
            this.textBox_CSS02_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS02_BF1DownRight
            // 
            this.textBox_CSS02_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS02_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS02_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS02_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS02_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CSS02_BF1DownRight.Name = "textBox_CSS02_BF1DownRight";
            this.textBox_CSS02_BF1DownRight.ReadOnly = true;
            this.textBox_CSS02_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS02_BF1DownRight.TabIndex = 139;
            this.textBox_CSS02_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_CS_S03
            // 
            this.tabPage_CS_S03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_S03.Controls.Add(this.label95);
            this.tabPage_CS_S03.Controls.Add(this.label96);
            this.tabPage_CS_S03.Controls.Add(this.label97);
            this.tabPage_CS_S03.Controls.Add(this.label98);
            this.tabPage_CS_S03.Controls.Add(this.label99);
            this.tabPage_CS_S03.Controls.Add(this.label100);
            this.tabPage_CS_S03.Controls.Add(this.label101);
            this.tabPage_CS_S03.Controls.Add(this.label102);
            this.tabPage_CS_S03.Controls.Add(this.label103);
            this.tabPage_CS_S03.Controls.Add(this.label104);
            this.tabPage_CS_S03.Controls.Add(this.label105);
            this.tabPage_CS_S03.Controls.Add(this.label106);
            this.tabPage_CS_S03.Controls.Add(this.label107);
            this.tabPage_CS_S03.Controls.Add(this.label108);
            this.tabPage_CS_S03.Controls.Add(this.label109);
            this.tabPage_CS_S03.Controls.Add(this.label110);
            this.tabPage_CS_S03.Controls.Add(this.label111);
            this.tabPage_CS_S03.Controls.Add(this.label112);
            this.tabPage_CS_S03.Controls.Add(this.label113);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_SUSCarrierLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_SUSCarrierRight);
            this.tabPage_CS_S03.Controls.Add(this.label114);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_SUSScanLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_SUSScanRight);
            this.tabPage_CS_S03.Controls.Add(this.label115);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU2CarrierLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU2CarrierRight);
            this.tabPage_CS_S03.Controls.Add(this.label116);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU2ScanLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU2ScanRight);
            this.tabPage_CS_S03.Controls.Add(this.label117);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU1CarrierLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU1CarrierRight);
            this.tabPage_CS_S03.Controls.Add(this.label118);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU1ScanLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_CU1ScanRight);
            this.tabPage_CS_S03.Controls.Add(this.label119);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF2UpLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF2UpRight);
            this.tabPage_CS_S03.Controls.Add(this.label120);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF2DownLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF2DownRight);
            this.tabPage_CS_S03.Controls.Add(this.label121);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF1UpLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF1UpRight);
            this.tabPage_CS_S03.Controls.Add(this.label122);
            this.tabPage_CS_S03.Controls.Add(this.label123);
            this.tabPage_CS_S03.Controls.Add(this.label124);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF1DownLeft);
            this.tabPage_CS_S03.Controls.Add(this.textBox_CSS03_BF1DownRight);
            this.tabPage_CS_S03.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_S03.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_S03.Name = "tabPage_CS_S03";
            this.tabPage_CS_S03.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_S03.TabIndex = 3;
            this.tabPage_CS_S03.Text = "CS-S03";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label95.ForeColor = System.Drawing.Color.White;
            this.label95.Location = new System.Drawing.Point(186, 396);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(29, 12);
            this.label95.TabIndex = 188;
            this.label95.Text = "Left";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label96.ForeColor = System.Drawing.Color.White;
            this.label96.Location = new System.Drawing.Point(186, 369);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(38, 12);
            this.label96.TabIndex = 187;
            this.label96.Text = "Right";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label97.ForeColor = System.Drawing.Color.White;
            this.label97.Location = new System.Drawing.Point(186, 313);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(29, 12);
            this.label97.TabIndex = 186;
            this.label97.Text = "Left";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label98.ForeColor = System.Drawing.Color.White;
            this.label98.Location = new System.Drawing.Point(186, 286);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(38, 12);
            this.label98.TabIndex = 185;
            this.label98.Text = "Right";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(186, 230);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(29, 12);
            this.label99.TabIndex = 184;
            this.label99.Text = "Left";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label100.ForeColor = System.Drawing.Color.White;
            this.label100.Location = new System.Drawing.Point(186, 203);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(38, 12);
            this.label100.TabIndex = 183;
            this.label100.Text = "Right";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label101.ForeColor = System.Drawing.Color.White;
            this.label101.Location = new System.Drawing.Point(186, 147);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(29, 12);
            this.label101.TabIndex = 182;
            this.label101.Text = "Left";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label102.ForeColor = System.Drawing.Color.White;
            this.label102.Location = new System.Drawing.Point(186, 120);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(38, 12);
            this.label102.TabIndex = 181;
            this.label102.Text = "Right";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label103.ForeColor = System.Drawing.Color.White;
            this.label103.Location = new System.Drawing.Point(186, 64);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(29, 12);
            this.label103.TabIndex = 180;
            this.label103.Text = "Left";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label104.ForeColor = System.Drawing.Color.White;
            this.label104.Location = new System.Drawing.Point(186, 37);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(38, 12);
            this.label104.TabIndex = 179;
            this.label104.Text = "Right";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label105.ForeColor = System.Drawing.Color.White;
            this.label105.Location = new System.Drawing.Point(32, 396);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(29, 12);
            this.label105.TabIndex = 178;
            this.label105.Text = "Left";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label106.ForeColor = System.Drawing.Color.White;
            this.label106.Location = new System.Drawing.Point(32, 369);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(38, 12);
            this.label106.TabIndex = 177;
            this.label106.Text = "Right";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label107.ForeColor = System.Drawing.Color.White;
            this.label107.Location = new System.Drawing.Point(32, 313);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(29, 12);
            this.label107.TabIndex = 176;
            this.label107.Text = "Left";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label108.ForeColor = System.Drawing.Color.White;
            this.label108.Location = new System.Drawing.Point(32, 286);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(38, 12);
            this.label108.TabIndex = 175;
            this.label108.Text = "Right";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label109.ForeColor = System.Drawing.Color.White;
            this.label109.Location = new System.Drawing.Point(32, 230);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(29, 12);
            this.label109.TabIndex = 174;
            this.label109.Text = "Left";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label110.ForeColor = System.Drawing.Color.White;
            this.label110.Location = new System.Drawing.Point(32, 203);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(38, 12);
            this.label110.TabIndex = 173;
            this.label110.Text = "Right";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label111.ForeColor = System.Drawing.Color.White;
            this.label111.Location = new System.Drawing.Point(32, 147);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(29, 12);
            this.label111.TabIndex = 172;
            this.label111.Text = "Left";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label112.ForeColor = System.Drawing.Color.White;
            this.label112.Location = new System.Drawing.Point(32, 120);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(38, 12);
            this.label112.TabIndex = 171;
            this.label112.Text = "Right";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label113.ForeColor = System.Drawing.Color.White;
            this.label113.Location = new System.Drawing.Point(225, 349);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(84, 12);
            this.label113.TabIndex = 170;
            this.label113.Text = "SUS_Carrier";
            // 
            // textBox_CSS03_SUSCarrierLeft
            // 
            this.textBox_CSS03_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CSS03_SUSCarrierLeft.Name = "textBox_CSS03_SUSCarrierLeft";
            this.textBox_CSS03_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CSS03_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CSS03_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_SUSCarrierRight
            // 
            this.textBox_CSS03_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CSS03_SUSCarrierRight.Name = "textBox_CSS03_SUSCarrierRight";
            this.textBox_CSS03_SUSCarrierRight.ReadOnly = true;
            this.textBox_CSS03_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_SUSCarrierRight.TabIndex = 168;
            this.textBox_CSS03_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label114.ForeColor = System.Drawing.Color.White;
            this.label114.Location = new System.Drawing.Point(71, 349);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(72, 12);
            this.label114.TabIndex = 167;
            this.label114.Text = "SUS_Scan";
            // 
            // textBox_CSS03_SUSScanLeft
            // 
            this.textBox_CSS03_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CSS03_SUSScanLeft.Name = "textBox_CSS03_SUSScanLeft";
            this.textBox_CSS03_SUSScanLeft.ReadOnly = true;
            this.textBox_CSS03_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_SUSScanLeft.TabIndex = 166;
            this.textBox_CSS03_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_SUSScanRight
            // 
            this.textBox_CSS03_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CSS03_SUSScanRight.Name = "textBox_CSS03_SUSScanRight";
            this.textBox_CSS03_SUSScanRight.ReadOnly = true;
            this.textBox_CSS03_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_SUSScanRight.TabIndex = 165;
            this.textBox_CSS03_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label115.ForeColor = System.Drawing.Color.White;
            this.label115.Location = new System.Drawing.Point(225, 266);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(83, 12);
            this.label115.TabIndex = 164;
            this.label115.Text = "CU2_Carrier";
            // 
            // textBox_CSS03_CU2CarrierLeft
            // 
            this.textBox_CSS03_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CSS03_CU2CarrierLeft.Name = "textBox_CSS03_CU2CarrierLeft";
            this.textBox_CSS03_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CSS03_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CSS03_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_CU2CarrierRight
            // 
            this.textBox_CSS03_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CSS03_CU2CarrierRight.Name = "textBox_CSS03_CU2CarrierRight";
            this.textBox_CSS03_CU2CarrierRight.ReadOnly = true;
            this.textBox_CSS03_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU2CarrierRight.TabIndex = 162;
            this.textBox_CSS03_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label116.ForeColor = System.Drawing.Color.White;
            this.label116.Location = new System.Drawing.Point(71, 266);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(71, 12);
            this.label116.TabIndex = 161;
            this.label116.Text = "CU2_Scan";
            // 
            // textBox_CSS03_CU2ScanLeft
            // 
            this.textBox_CSS03_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CSS03_CU2ScanLeft.Name = "textBox_CSS03_CU2ScanLeft";
            this.textBox_CSS03_CU2ScanLeft.ReadOnly = true;
            this.textBox_CSS03_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU2ScanLeft.TabIndex = 160;
            this.textBox_CSS03_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_CU2ScanRight
            // 
            this.textBox_CSS03_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CSS03_CU2ScanRight.Name = "textBox_CSS03_CU2ScanRight";
            this.textBox_CSS03_CU2ScanRight.ReadOnly = true;
            this.textBox_CSS03_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU2ScanRight.TabIndex = 159;
            this.textBox_CSS03_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label117.ForeColor = System.Drawing.Color.White;
            this.label117.Location = new System.Drawing.Point(225, 183);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(83, 12);
            this.label117.TabIndex = 158;
            this.label117.Text = "CU1_Carrier";
            // 
            // textBox_CSS03_CU1CarrierLeft
            // 
            this.textBox_CSS03_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CSS03_CU1CarrierLeft.Name = "textBox_CSS03_CU1CarrierLeft";
            this.textBox_CSS03_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CSS03_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CSS03_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_CU1CarrierRight
            // 
            this.textBox_CSS03_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CSS03_CU1CarrierRight.Name = "textBox_CSS03_CU1CarrierRight";
            this.textBox_CSS03_CU1CarrierRight.ReadOnly = true;
            this.textBox_CSS03_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU1CarrierRight.TabIndex = 156;
            this.textBox_CSS03_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label118.ForeColor = System.Drawing.Color.White;
            this.label118.Location = new System.Drawing.Point(71, 183);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(71, 12);
            this.label118.TabIndex = 155;
            this.label118.Text = "CU1_Scan";
            // 
            // textBox_CSS03_CU1ScanLeft
            // 
            this.textBox_CSS03_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CSS03_CU1ScanLeft.Name = "textBox_CSS03_CU1ScanLeft";
            this.textBox_CSS03_CU1ScanLeft.ReadOnly = true;
            this.textBox_CSS03_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU1ScanLeft.TabIndex = 154;
            this.textBox_CSS03_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_CU1ScanRight
            // 
            this.textBox_CSS03_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CSS03_CU1ScanRight.Name = "textBox_CSS03_CU1ScanRight";
            this.textBox_CSS03_CU1ScanRight.ReadOnly = true;
            this.textBox_CSS03_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_CU1ScanRight.TabIndex = 153;
            this.textBox_CSS03_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label119.ForeColor = System.Drawing.Color.White;
            this.label119.Location = new System.Drawing.Point(225, 100);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(53, 12);
            this.label119.TabIndex = 152;
            this.label119.Text = "BF2_Up";
            // 
            // textBox_CSS03_BF2UpLeft
            // 
            this.textBox_CSS03_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CSS03_BF2UpLeft.Name = "textBox_CSS03_BF2UpLeft";
            this.textBox_CSS03_BF2UpLeft.ReadOnly = true;
            this.textBox_CSS03_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF2UpLeft.TabIndex = 151;
            this.textBox_CSS03_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_BF2UpRight
            // 
            this.textBox_CSS03_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CSS03_BF2UpRight.Name = "textBox_CSS03_BF2UpRight";
            this.textBox_CSS03_BF2UpRight.ReadOnly = true;
            this.textBox_CSS03_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF2UpRight.TabIndex = 150;
            this.textBox_CSS03_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label120.ForeColor = System.Drawing.Color.White;
            this.label120.Location = new System.Drawing.Point(71, 100);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(72, 12);
            this.label120.TabIndex = 149;
            this.label120.Text = "BF2_Down";
            // 
            // textBox_CSS03_BF2DownLeft
            // 
            this.textBox_CSS03_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CSS03_BF2DownLeft.Name = "textBox_CSS03_BF2DownLeft";
            this.textBox_CSS03_BF2DownLeft.ReadOnly = true;
            this.textBox_CSS03_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF2DownLeft.TabIndex = 148;
            this.textBox_CSS03_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_BF2DownRight
            // 
            this.textBox_CSS03_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CSS03_BF2DownRight.Name = "textBox_CSS03_BF2DownRight";
            this.textBox_CSS03_BF2DownRight.ReadOnly = true;
            this.textBox_CSS03_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF2DownRight.TabIndex = 147;
            this.textBox_CSS03_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label121.ForeColor = System.Drawing.Color.White;
            this.label121.Location = new System.Drawing.Point(225, 17);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(53, 12);
            this.label121.TabIndex = 146;
            this.label121.Text = "BF1_Up";
            // 
            // textBox_CSS03_BF1UpLeft
            // 
            this.textBox_CSS03_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CSS03_BF1UpLeft.Name = "textBox_CSS03_BF1UpLeft";
            this.textBox_CSS03_BF1UpLeft.ReadOnly = true;
            this.textBox_CSS03_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF1UpLeft.TabIndex = 145;
            this.textBox_CSS03_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_BF1UpRight
            // 
            this.textBox_CSS03_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CSS03_BF1UpRight.Name = "textBox_CSS03_BF1UpRight";
            this.textBox_CSS03_BF1UpRight.ReadOnly = true;
            this.textBox_CSS03_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF1UpRight.TabIndex = 144;
            this.textBox_CSS03_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label122.ForeColor = System.Drawing.Color.White;
            this.label122.Location = new System.Drawing.Point(32, 64);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(29, 12);
            this.label122.TabIndex = 143;
            this.label122.Text = "Left";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label123.ForeColor = System.Drawing.Color.White;
            this.label123.Location = new System.Drawing.Point(32, 37);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(38, 12);
            this.label123.TabIndex = 142;
            this.label123.Text = "Right";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label124.ForeColor = System.Drawing.Color.White;
            this.label124.Location = new System.Drawing.Point(71, 17);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(72, 12);
            this.label124.TabIndex = 141;
            this.label124.Text = "BF1_Down";
            // 
            // textBox_CSS03_BF1DownLeft
            // 
            this.textBox_CSS03_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CSS03_BF1DownLeft.Name = "textBox_CSS03_BF1DownLeft";
            this.textBox_CSS03_BF1DownLeft.ReadOnly = true;
            this.textBox_CSS03_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF1DownLeft.TabIndex = 140;
            this.textBox_CSS03_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS03_BF1DownRight
            // 
            this.textBox_CSS03_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS03_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS03_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS03_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS03_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CSS03_BF1DownRight.Name = "textBox_CSS03_BF1DownRight";
            this.textBox_CSS03_BF1DownRight.ReadOnly = true;
            this.textBox_CSS03_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS03_BF1DownRight.TabIndex = 139;
            this.textBox_CSS03_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_CS_S04
            // 
            this.tabPage_CS_S04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_S04.Controls.Add(this.label125);
            this.tabPage_CS_S04.Controls.Add(this.label126);
            this.tabPage_CS_S04.Controls.Add(this.label127);
            this.tabPage_CS_S04.Controls.Add(this.label128);
            this.tabPage_CS_S04.Controls.Add(this.label129);
            this.tabPage_CS_S04.Controls.Add(this.label130);
            this.tabPage_CS_S04.Controls.Add(this.label131);
            this.tabPage_CS_S04.Controls.Add(this.label132);
            this.tabPage_CS_S04.Controls.Add(this.label133);
            this.tabPage_CS_S04.Controls.Add(this.label134);
            this.tabPage_CS_S04.Controls.Add(this.label135);
            this.tabPage_CS_S04.Controls.Add(this.label136);
            this.tabPage_CS_S04.Controls.Add(this.label137);
            this.tabPage_CS_S04.Controls.Add(this.label138);
            this.tabPage_CS_S04.Controls.Add(this.label139);
            this.tabPage_CS_S04.Controls.Add(this.label140);
            this.tabPage_CS_S04.Controls.Add(this.label141);
            this.tabPage_CS_S04.Controls.Add(this.label142);
            this.tabPage_CS_S04.Controls.Add(this.label143);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_SUSCarrierLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_SUSCarrierRight);
            this.tabPage_CS_S04.Controls.Add(this.label144);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_SUSScanLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_SUSScanRight);
            this.tabPage_CS_S04.Controls.Add(this.label145);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU2CarrierLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU2CarrierRight);
            this.tabPage_CS_S04.Controls.Add(this.label146);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU2ScanLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU2ScanRight);
            this.tabPage_CS_S04.Controls.Add(this.label147);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU1CarrierLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU1CarrierRight);
            this.tabPage_CS_S04.Controls.Add(this.label148);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU1ScanLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_CU1ScanRight);
            this.tabPage_CS_S04.Controls.Add(this.label149);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF2UpLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF2UpRight);
            this.tabPage_CS_S04.Controls.Add(this.label150);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF2DownLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF2DownRight);
            this.tabPage_CS_S04.Controls.Add(this.label151);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF1UpLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF1UpRight);
            this.tabPage_CS_S04.Controls.Add(this.label152);
            this.tabPage_CS_S04.Controls.Add(this.label153);
            this.tabPage_CS_S04.Controls.Add(this.label154);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF1DownLeft);
            this.tabPage_CS_S04.Controls.Add(this.textBox_CSS04_BF1DownRight);
            this.tabPage_CS_S04.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_S04.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_S04.Name = "tabPage_CS_S04";
            this.tabPage_CS_S04.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_S04.TabIndex = 4;
            this.tabPage_CS_S04.Text = "CS-S04";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label125.ForeColor = System.Drawing.Color.White;
            this.label125.Location = new System.Drawing.Point(186, 396);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(29, 12);
            this.label125.TabIndex = 188;
            this.label125.Text = "Left";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label126.ForeColor = System.Drawing.Color.White;
            this.label126.Location = new System.Drawing.Point(186, 369);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(38, 12);
            this.label126.TabIndex = 187;
            this.label126.Text = "Right";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label127.ForeColor = System.Drawing.Color.White;
            this.label127.Location = new System.Drawing.Point(186, 313);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(29, 12);
            this.label127.TabIndex = 186;
            this.label127.Text = "Left";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label128.ForeColor = System.Drawing.Color.White;
            this.label128.Location = new System.Drawing.Point(186, 286);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(38, 12);
            this.label128.TabIndex = 185;
            this.label128.Text = "Right";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label129.ForeColor = System.Drawing.Color.White;
            this.label129.Location = new System.Drawing.Point(186, 230);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(29, 12);
            this.label129.TabIndex = 184;
            this.label129.Text = "Left";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label130.ForeColor = System.Drawing.Color.White;
            this.label130.Location = new System.Drawing.Point(186, 203);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(38, 12);
            this.label130.TabIndex = 183;
            this.label130.Text = "Right";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label131.ForeColor = System.Drawing.Color.White;
            this.label131.Location = new System.Drawing.Point(186, 147);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(29, 12);
            this.label131.TabIndex = 182;
            this.label131.Text = "Left";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label132.ForeColor = System.Drawing.Color.White;
            this.label132.Location = new System.Drawing.Point(186, 120);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(38, 12);
            this.label132.TabIndex = 181;
            this.label132.Text = "Right";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label133.ForeColor = System.Drawing.Color.White;
            this.label133.Location = new System.Drawing.Point(186, 64);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(29, 12);
            this.label133.TabIndex = 180;
            this.label133.Text = "Left";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label134.ForeColor = System.Drawing.Color.White;
            this.label134.Location = new System.Drawing.Point(186, 37);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(38, 12);
            this.label134.TabIndex = 179;
            this.label134.Text = "Right";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label135.ForeColor = System.Drawing.Color.White;
            this.label135.Location = new System.Drawing.Point(32, 396);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(29, 12);
            this.label135.TabIndex = 178;
            this.label135.Text = "Left";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label136.ForeColor = System.Drawing.Color.White;
            this.label136.Location = new System.Drawing.Point(32, 369);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(38, 12);
            this.label136.TabIndex = 177;
            this.label136.Text = "Right";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label137.ForeColor = System.Drawing.Color.White;
            this.label137.Location = new System.Drawing.Point(32, 313);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(29, 12);
            this.label137.TabIndex = 176;
            this.label137.Text = "Left";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label138.ForeColor = System.Drawing.Color.White;
            this.label138.Location = new System.Drawing.Point(32, 286);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(38, 12);
            this.label138.TabIndex = 175;
            this.label138.Text = "Right";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label139.ForeColor = System.Drawing.Color.White;
            this.label139.Location = new System.Drawing.Point(32, 230);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(29, 12);
            this.label139.TabIndex = 174;
            this.label139.Text = "Left";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label140.ForeColor = System.Drawing.Color.White;
            this.label140.Location = new System.Drawing.Point(32, 203);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(38, 12);
            this.label140.TabIndex = 173;
            this.label140.Text = "Right";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label141.ForeColor = System.Drawing.Color.White;
            this.label141.Location = new System.Drawing.Point(32, 147);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(29, 12);
            this.label141.TabIndex = 172;
            this.label141.Text = "Left";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label142.ForeColor = System.Drawing.Color.White;
            this.label142.Location = new System.Drawing.Point(32, 120);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(38, 12);
            this.label142.TabIndex = 171;
            this.label142.Text = "Right";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label143.ForeColor = System.Drawing.Color.White;
            this.label143.Location = new System.Drawing.Point(225, 349);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(84, 12);
            this.label143.TabIndex = 170;
            this.label143.Text = "SUS_Carrier";
            // 
            // textBox_CSS04_SUSCarrierLeft
            // 
            this.textBox_CSS04_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CSS04_SUSCarrierLeft.Name = "textBox_CSS04_SUSCarrierLeft";
            this.textBox_CSS04_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CSS04_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CSS04_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_SUSCarrierRight
            // 
            this.textBox_CSS04_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CSS04_SUSCarrierRight.Name = "textBox_CSS04_SUSCarrierRight";
            this.textBox_CSS04_SUSCarrierRight.ReadOnly = true;
            this.textBox_CSS04_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_SUSCarrierRight.TabIndex = 168;
            this.textBox_CSS04_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label144.ForeColor = System.Drawing.Color.White;
            this.label144.Location = new System.Drawing.Point(71, 349);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(72, 12);
            this.label144.TabIndex = 167;
            this.label144.Text = "SUS_Scan";
            // 
            // textBox_CSS04_SUSScanLeft
            // 
            this.textBox_CSS04_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CSS04_SUSScanLeft.Name = "textBox_CSS04_SUSScanLeft";
            this.textBox_CSS04_SUSScanLeft.ReadOnly = true;
            this.textBox_CSS04_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_SUSScanLeft.TabIndex = 166;
            this.textBox_CSS04_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_SUSScanRight
            // 
            this.textBox_CSS04_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CSS04_SUSScanRight.Name = "textBox_CSS04_SUSScanRight";
            this.textBox_CSS04_SUSScanRight.ReadOnly = true;
            this.textBox_CSS04_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_SUSScanRight.TabIndex = 165;
            this.textBox_CSS04_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label145.ForeColor = System.Drawing.Color.White;
            this.label145.Location = new System.Drawing.Point(225, 266);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(83, 12);
            this.label145.TabIndex = 164;
            this.label145.Text = "CU2_Carrier";
            // 
            // textBox_CSS04_CU2CarrierLeft
            // 
            this.textBox_CSS04_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CSS04_CU2CarrierLeft.Name = "textBox_CSS04_CU2CarrierLeft";
            this.textBox_CSS04_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CSS04_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CSS04_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_CU2CarrierRight
            // 
            this.textBox_CSS04_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CSS04_CU2CarrierRight.Name = "textBox_CSS04_CU2CarrierRight";
            this.textBox_CSS04_CU2CarrierRight.ReadOnly = true;
            this.textBox_CSS04_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU2CarrierRight.TabIndex = 162;
            this.textBox_CSS04_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label146.ForeColor = System.Drawing.Color.White;
            this.label146.Location = new System.Drawing.Point(71, 266);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(71, 12);
            this.label146.TabIndex = 161;
            this.label146.Text = "CU2_Scan";
            // 
            // textBox_CSS04_CU2ScanLeft
            // 
            this.textBox_CSS04_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CSS04_CU2ScanLeft.Name = "textBox_CSS04_CU2ScanLeft";
            this.textBox_CSS04_CU2ScanLeft.ReadOnly = true;
            this.textBox_CSS04_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU2ScanLeft.TabIndex = 160;
            this.textBox_CSS04_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_CU2ScanRight
            // 
            this.textBox_CSS04_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CSS04_CU2ScanRight.Name = "textBox_CSS04_CU2ScanRight";
            this.textBox_CSS04_CU2ScanRight.ReadOnly = true;
            this.textBox_CSS04_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU2ScanRight.TabIndex = 159;
            this.textBox_CSS04_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label147.ForeColor = System.Drawing.Color.White;
            this.label147.Location = new System.Drawing.Point(225, 183);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(83, 12);
            this.label147.TabIndex = 158;
            this.label147.Text = "CU1_Carrier";
            // 
            // textBox_CSS04_CU1CarrierLeft
            // 
            this.textBox_CSS04_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CSS04_CU1CarrierLeft.Name = "textBox_CSS04_CU1CarrierLeft";
            this.textBox_CSS04_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CSS04_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CSS04_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_CU1CarrierRight
            // 
            this.textBox_CSS04_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CSS04_CU1CarrierRight.Name = "textBox_CSS04_CU1CarrierRight";
            this.textBox_CSS04_CU1CarrierRight.ReadOnly = true;
            this.textBox_CSS04_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU1CarrierRight.TabIndex = 156;
            this.textBox_CSS04_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label148.ForeColor = System.Drawing.Color.White;
            this.label148.Location = new System.Drawing.Point(71, 183);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(71, 12);
            this.label148.TabIndex = 155;
            this.label148.Text = "CU1_Scan";
            // 
            // textBox_CSS04_CU1ScanLeft
            // 
            this.textBox_CSS04_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CSS04_CU1ScanLeft.Name = "textBox_CSS04_CU1ScanLeft";
            this.textBox_CSS04_CU1ScanLeft.ReadOnly = true;
            this.textBox_CSS04_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU1ScanLeft.TabIndex = 154;
            this.textBox_CSS04_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_CU1ScanRight
            // 
            this.textBox_CSS04_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CSS04_CU1ScanRight.Name = "textBox_CSS04_CU1ScanRight";
            this.textBox_CSS04_CU1ScanRight.ReadOnly = true;
            this.textBox_CSS04_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_CU1ScanRight.TabIndex = 153;
            this.textBox_CSS04_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label149.ForeColor = System.Drawing.Color.White;
            this.label149.Location = new System.Drawing.Point(225, 100);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(53, 12);
            this.label149.TabIndex = 152;
            this.label149.Text = "BF2_Up";
            // 
            // textBox_CSS04_BF2UpLeft
            // 
            this.textBox_CSS04_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CSS04_BF2UpLeft.Name = "textBox_CSS04_BF2UpLeft";
            this.textBox_CSS04_BF2UpLeft.ReadOnly = true;
            this.textBox_CSS04_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF2UpLeft.TabIndex = 151;
            this.textBox_CSS04_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_BF2UpRight
            // 
            this.textBox_CSS04_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CSS04_BF2UpRight.Name = "textBox_CSS04_BF2UpRight";
            this.textBox_CSS04_BF2UpRight.ReadOnly = true;
            this.textBox_CSS04_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF2UpRight.TabIndex = 150;
            this.textBox_CSS04_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label150.ForeColor = System.Drawing.Color.White;
            this.label150.Location = new System.Drawing.Point(71, 100);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(72, 12);
            this.label150.TabIndex = 149;
            this.label150.Text = "BF2_Down";
            // 
            // textBox_CSS04_BF2DownLeft
            // 
            this.textBox_CSS04_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CSS04_BF2DownLeft.Name = "textBox_CSS04_BF2DownLeft";
            this.textBox_CSS04_BF2DownLeft.ReadOnly = true;
            this.textBox_CSS04_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF2DownLeft.TabIndex = 148;
            this.textBox_CSS04_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_BF2DownRight
            // 
            this.textBox_CSS04_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CSS04_BF2DownRight.Name = "textBox_CSS04_BF2DownRight";
            this.textBox_CSS04_BF2DownRight.ReadOnly = true;
            this.textBox_CSS04_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF2DownRight.TabIndex = 147;
            this.textBox_CSS04_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label151.ForeColor = System.Drawing.Color.White;
            this.label151.Location = new System.Drawing.Point(225, 17);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(53, 12);
            this.label151.TabIndex = 146;
            this.label151.Text = "BF1_Up";
            // 
            // textBox_CSS04_BF1UpLeft
            // 
            this.textBox_CSS04_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CSS04_BF1UpLeft.Name = "textBox_CSS04_BF1UpLeft";
            this.textBox_CSS04_BF1UpLeft.ReadOnly = true;
            this.textBox_CSS04_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF1UpLeft.TabIndex = 145;
            this.textBox_CSS04_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_BF1UpRight
            // 
            this.textBox_CSS04_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CSS04_BF1UpRight.Name = "textBox_CSS04_BF1UpRight";
            this.textBox_CSS04_BF1UpRight.ReadOnly = true;
            this.textBox_CSS04_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF1UpRight.TabIndex = 144;
            this.textBox_CSS04_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label152.ForeColor = System.Drawing.Color.White;
            this.label152.Location = new System.Drawing.Point(32, 64);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(29, 12);
            this.label152.TabIndex = 143;
            this.label152.Text = "Left";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label153.ForeColor = System.Drawing.Color.White;
            this.label153.Location = new System.Drawing.Point(32, 37);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(38, 12);
            this.label153.TabIndex = 142;
            this.label153.Text = "Right";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label154.ForeColor = System.Drawing.Color.White;
            this.label154.Location = new System.Drawing.Point(71, 17);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(72, 12);
            this.label154.TabIndex = 141;
            this.label154.Text = "BF1_Down";
            // 
            // textBox_CSS04_BF1DownLeft
            // 
            this.textBox_CSS04_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CSS04_BF1DownLeft.Name = "textBox_CSS04_BF1DownLeft";
            this.textBox_CSS04_BF1DownLeft.ReadOnly = true;
            this.textBox_CSS04_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF1DownLeft.TabIndex = 140;
            this.textBox_CSS04_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS04_BF1DownRight
            // 
            this.textBox_CSS04_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS04_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS04_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS04_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS04_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CSS04_BF1DownRight.Name = "textBox_CSS04_BF1DownRight";
            this.textBox_CSS04_BF1DownRight.ReadOnly = true;
            this.textBox_CSS04_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS04_BF1DownRight.TabIndex = 139;
            this.textBox_CSS04_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_CS_S05
            // 
            this.tabPage_CS_S05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage_CS_S05.Controls.Add(this.label155);
            this.tabPage_CS_S05.Controls.Add(this.label156);
            this.tabPage_CS_S05.Controls.Add(this.label157);
            this.tabPage_CS_S05.Controls.Add(this.label158);
            this.tabPage_CS_S05.Controls.Add(this.label159);
            this.tabPage_CS_S05.Controls.Add(this.label160);
            this.tabPage_CS_S05.Controls.Add(this.label161);
            this.tabPage_CS_S05.Controls.Add(this.label162);
            this.tabPage_CS_S05.Controls.Add(this.label163);
            this.tabPage_CS_S05.Controls.Add(this.label164);
            this.tabPage_CS_S05.Controls.Add(this.label165);
            this.tabPage_CS_S05.Controls.Add(this.label166);
            this.tabPage_CS_S05.Controls.Add(this.label167);
            this.tabPage_CS_S05.Controls.Add(this.label168);
            this.tabPage_CS_S05.Controls.Add(this.label169);
            this.tabPage_CS_S05.Controls.Add(this.label170);
            this.tabPage_CS_S05.Controls.Add(this.label171);
            this.tabPage_CS_S05.Controls.Add(this.label172);
            this.tabPage_CS_S05.Controls.Add(this.label173);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_SUSCarrierLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_SUSCarrierRight);
            this.tabPage_CS_S05.Controls.Add(this.label174);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_SUSScanLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_SUSScanRight);
            this.tabPage_CS_S05.Controls.Add(this.label175);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU2CarrierLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU2CarrierRight);
            this.tabPage_CS_S05.Controls.Add(this.label176);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU2ScanLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU2ScanRight);
            this.tabPage_CS_S05.Controls.Add(this.label177);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU1CarrierLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU1CarrierRight);
            this.tabPage_CS_S05.Controls.Add(this.label178);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU1ScanLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_CU1ScanRight);
            this.tabPage_CS_S05.Controls.Add(this.label179);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF2UpLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF2UpRight);
            this.tabPage_CS_S05.Controls.Add(this.label180);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF2DownLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF2DownRight);
            this.tabPage_CS_S05.Controls.Add(this.label181);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF1UpLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF1UpRight);
            this.tabPage_CS_S05.Controls.Add(this.label182);
            this.tabPage_CS_S05.Controls.Add(this.label183);
            this.tabPage_CS_S05.Controls.Add(this.label184);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF1DownLeft);
            this.tabPage_CS_S05.Controls.Add(this.textBox_CSS05_BF1DownRight);
            this.tabPage_CS_S05.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CS_S05.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CS_S05.Name = "tabPage_CS_S05";
            this.tabPage_CS_S05.Size = new System.Drawing.Size(358, 428);
            this.tabPage_CS_S05.TabIndex = 5;
            this.tabPage_CS_S05.Text = "CS-S05";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label155.ForeColor = System.Drawing.Color.White;
            this.label155.Location = new System.Drawing.Point(186, 396);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(29, 12);
            this.label155.TabIndex = 188;
            this.label155.Text = "Left";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label156.ForeColor = System.Drawing.Color.White;
            this.label156.Location = new System.Drawing.Point(186, 369);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(38, 12);
            this.label156.TabIndex = 187;
            this.label156.Text = "Right";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label157.ForeColor = System.Drawing.Color.White;
            this.label157.Location = new System.Drawing.Point(186, 313);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(29, 12);
            this.label157.TabIndex = 186;
            this.label157.Text = "Left";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label158.ForeColor = System.Drawing.Color.White;
            this.label158.Location = new System.Drawing.Point(186, 286);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(38, 12);
            this.label158.TabIndex = 185;
            this.label158.Text = "Right";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label159.ForeColor = System.Drawing.Color.White;
            this.label159.Location = new System.Drawing.Point(186, 230);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(29, 12);
            this.label159.TabIndex = 184;
            this.label159.Text = "Left";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label160.ForeColor = System.Drawing.Color.White;
            this.label160.Location = new System.Drawing.Point(186, 203);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(38, 12);
            this.label160.TabIndex = 183;
            this.label160.Text = "Right";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label161.ForeColor = System.Drawing.Color.White;
            this.label161.Location = new System.Drawing.Point(186, 147);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(29, 12);
            this.label161.TabIndex = 182;
            this.label161.Text = "Left";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label162.ForeColor = System.Drawing.Color.White;
            this.label162.Location = new System.Drawing.Point(186, 120);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(38, 12);
            this.label162.TabIndex = 181;
            this.label162.Text = "Right";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label163.ForeColor = System.Drawing.Color.White;
            this.label163.Location = new System.Drawing.Point(186, 64);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(29, 12);
            this.label163.TabIndex = 180;
            this.label163.Text = "Left";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label164.ForeColor = System.Drawing.Color.White;
            this.label164.Location = new System.Drawing.Point(186, 37);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(38, 12);
            this.label164.TabIndex = 179;
            this.label164.Text = "Right";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label165.ForeColor = System.Drawing.Color.White;
            this.label165.Location = new System.Drawing.Point(32, 396);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(29, 12);
            this.label165.TabIndex = 178;
            this.label165.Text = "Left";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label166.ForeColor = System.Drawing.Color.White;
            this.label166.Location = new System.Drawing.Point(32, 369);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(38, 12);
            this.label166.TabIndex = 177;
            this.label166.Text = "Right";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label167.ForeColor = System.Drawing.Color.White;
            this.label167.Location = new System.Drawing.Point(32, 313);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(29, 12);
            this.label167.TabIndex = 176;
            this.label167.Text = "Left";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label168.ForeColor = System.Drawing.Color.White;
            this.label168.Location = new System.Drawing.Point(32, 286);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(38, 12);
            this.label168.TabIndex = 175;
            this.label168.Text = "Right";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label169.ForeColor = System.Drawing.Color.White;
            this.label169.Location = new System.Drawing.Point(32, 230);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(29, 12);
            this.label169.TabIndex = 174;
            this.label169.Text = "Left";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label170.ForeColor = System.Drawing.Color.White;
            this.label170.Location = new System.Drawing.Point(32, 203);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(38, 12);
            this.label170.TabIndex = 173;
            this.label170.Text = "Right";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label171.ForeColor = System.Drawing.Color.White;
            this.label171.Location = new System.Drawing.Point(32, 147);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(29, 12);
            this.label171.TabIndex = 172;
            this.label171.Text = "Left";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label172.ForeColor = System.Drawing.Color.White;
            this.label172.Location = new System.Drawing.Point(32, 120);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(38, 12);
            this.label172.TabIndex = 171;
            this.label172.Text = "Right";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label173.ForeColor = System.Drawing.Color.White;
            this.label173.Location = new System.Drawing.Point(225, 349);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(84, 12);
            this.label173.TabIndex = 170;
            this.label173.Text = "SUS_Carrier";
            // 
            // textBox_CSS05_SUSCarrierLeft
            // 
            this.textBox_CSS05_SUSCarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_SUSCarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_SUSCarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_SUSCarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_SUSCarrierLeft.Location = new System.Drawing.Point(227, 391);
            this.textBox_CSS05_SUSCarrierLeft.Name = "textBox_CSS05_SUSCarrierLeft";
            this.textBox_CSS05_SUSCarrierLeft.ReadOnly = true;
            this.textBox_CSS05_SUSCarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_SUSCarrierLeft.TabIndex = 169;
            this.textBox_CSS05_SUSCarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_SUSCarrierRight
            // 
            this.textBox_CSS05_SUSCarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_SUSCarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_SUSCarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_SUSCarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_SUSCarrierRight.Location = new System.Drawing.Point(227, 364);
            this.textBox_CSS05_SUSCarrierRight.Name = "textBox_CSS05_SUSCarrierRight";
            this.textBox_CSS05_SUSCarrierRight.ReadOnly = true;
            this.textBox_CSS05_SUSCarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_SUSCarrierRight.TabIndex = 168;
            this.textBox_CSS05_SUSCarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label174.ForeColor = System.Drawing.Color.White;
            this.label174.Location = new System.Drawing.Point(71, 349);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(72, 12);
            this.label174.TabIndex = 167;
            this.label174.Text = "SUS_Scan";
            // 
            // textBox_CSS05_SUSScanLeft
            // 
            this.textBox_CSS05_SUSScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_SUSScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_SUSScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_SUSScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_SUSScanLeft.Location = new System.Drawing.Point(73, 391);
            this.textBox_CSS05_SUSScanLeft.Name = "textBox_CSS05_SUSScanLeft";
            this.textBox_CSS05_SUSScanLeft.ReadOnly = true;
            this.textBox_CSS05_SUSScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_SUSScanLeft.TabIndex = 166;
            this.textBox_CSS05_SUSScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_SUSScanRight
            // 
            this.textBox_CSS05_SUSScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_SUSScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_SUSScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_SUSScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_SUSScanRight.Location = new System.Drawing.Point(73, 364);
            this.textBox_CSS05_SUSScanRight.Name = "textBox_CSS05_SUSScanRight";
            this.textBox_CSS05_SUSScanRight.ReadOnly = true;
            this.textBox_CSS05_SUSScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_SUSScanRight.TabIndex = 165;
            this.textBox_CSS05_SUSScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label175.ForeColor = System.Drawing.Color.White;
            this.label175.Location = new System.Drawing.Point(225, 266);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(83, 12);
            this.label175.TabIndex = 164;
            this.label175.Text = "CU2_Carrier";
            // 
            // textBox_CSS05_CU2CarrierLeft
            // 
            this.textBox_CSS05_CU2CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU2CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU2CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU2CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU2CarrierLeft.Location = new System.Drawing.Point(227, 308);
            this.textBox_CSS05_CU2CarrierLeft.Name = "textBox_CSS05_CU2CarrierLeft";
            this.textBox_CSS05_CU2CarrierLeft.ReadOnly = true;
            this.textBox_CSS05_CU2CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU2CarrierLeft.TabIndex = 163;
            this.textBox_CSS05_CU2CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_CU2CarrierRight
            // 
            this.textBox_CSS05_CU2CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU2CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU2CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU2CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU2CarrierRight.Location = new System.Drawing.Point(227, 281);
            this.textBox_CSS05_CU2CarrierRight.Name = "textBox_CSS05_CU2CarrierRight";
            this.textBox_CSS05_CU2CarrierRight.ReadOnly = true;
            this.textBox_CSS05_CU2CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU2CarrierRight.TabIndex = 162;
            this.textBox_CSS05_CU2CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label176.ForeColor = System.Drawing.Color.White;
            this.label176.Location = new System.Drawing.Point(71, 266);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(71, 12);
            this.label176.TabIndex = 161;
            this.label176.Text = "CU2_Scan";
            // 
            // textBox_CSS05_CU2ScanLeft
            // 
            this.textBox_CSS05_CU2ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU2ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU2ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU2ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU2ScanLeft.Location = new System.Drawing.Point(73, 308);
            this.textBox_CSS05_CU2ScanLeft.Name = "textBox_CSS05_CU2ScanLeft";
            this.textBox_CSS05_CU2ScanLeft.ReadOnly = true;
            this.textBox_CSS05_CU2ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU2ScanLeft.TabIndex = 160;
            this.textBox_CSS05_CU2ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_CU2ScanRight
            // 
            this.textBox_CSS05_CU2ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU2ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU2ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU2ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU2ScanRight.Location = new System.Drawing.Point(73, 281);
            this.textBox_CSS05_CU2ScanRight.Name = "textBox_CSS05_CU2ScanRight";
            this.textBox_CSS05_CU2ScanRight.ReadOnly = true;
            this.textBox_CSS05_CU2ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU2ScanRight.TabIndex = 159;
            this.textBox_CSS05_CU2ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label177.ForeColor = System.Drawing.Color.White;
            this.label177.Location = new System.Drawing.Point(225, 183);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(83, 12);
            this.label177.TabIndex = 158;
            this.label177.Text = "CU1_Carrier";
            // 
            // textBox_CSS05_CU1CarrierLeft
            // 
            this.textBox_CSS05_CU1CarrierLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU1CarrierLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU1CarrierLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU1CarrierLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU1CarrierLeft.Location = new System.Drawing.Point(227, 225);
            this.textBox_CSS05_CU1CarrierLeft.Name = "textBox_CSS05_CU1CarrierLeft";
            this.textBox_CSS05_CU1CarrierLeft.ReadOnly = true;
            this.textBox_CSS05_CU1CarrierLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU1CarrierLeft.TabIndex = 157;
            this.textBox_CSS05_CU1CarrierLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_CU1CarrierRight
            // 
            this.textBox_CSS05_CU1CarrierRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU1CarrierRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU1CarrierRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU1CarrierRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU1CarrierRight.Location = new System.Drawing.Point(227, 198);
            this.textBox_CSS05_CU1CarrierRight.Name = "textBox_CSS05_CU1CarrierRight";
            this.textBox_CSS05_CU1CarrierRight.ReadOnly = true;
            this.textBox_CSS05_CU1CarrierRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU1CarrierRight.TabIndex = 156;
            this.textBox_CSS05_CU1CarrierRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label178.ForeColor = System.Drawing.Color.White;
            this.label178.Location = new System.Drawing.Point(71, 183);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(71, 12);
            this.label178.TabIndex = 155;
            this.label178.Text = "CU1_Scan";
            // 
            // textBox_CSS05_CU1ScanLeft
            // 
            this.textBox_CSS05_CU1ScanLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU1ScanLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU1ScanLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU1ScanLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU1ScanLeft.Location = new System.Drawing.Point(73, 225);
            this.textBox_CSS05_CU1ScanLeft.Name = "textBox_CSS05_CU1ScanLeft";
            this.textBox_CSS05_CU1ScanLeft.ReadOnly = true;
            this.textBox_CSS05_CU1ScanLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU1ScanLeft.TabIndex = 154;
            this.textBox_CSS05_CU1ScanLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_CU1ScanRight
            // 
            this.textBox_CSS05_CU1ScanRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_CU1ScanRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_CU1ScanRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_CU1ScanRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_CU1ScanRight.Location = new System.Drawing.Point(73, 198);
            this.textBox_CSS05_CU1ScanRight.Name = "textBox_CSS05_CU1ScanRight";
            this.textBox_CSS05_CU1ScanRight.ReadOnly = true;
            this.textBox_CSS05_CU1ScanRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_CU1ScanRight.TabIndex = 153;
            this.textBox_CSS05_CU1ScanRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label179.ForeColor = System.Drawing.Color.White;
            this.label179.Location = new System.Drawing.Point(225, 100);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(53, 12);
            this.label179.TabIndex = 152;
            this.label179.Text = "BF2_Up";
            // 
            // textBox_CSS05_BF2UpLeft
            // 
            this.textBox_CSS05_BF2UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF2UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF2UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF2UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF2UpLeft.Location = new System.Drawing.Point(227, 142);
            this.textBox_CSS05_BF2UpLeft.Name = "textBox_CSS05_BF2UpLeft";
            this.textBox_CSS05_BF2UpLeft.ReadOnly = true;
            this.textBox_CSS05_BF2UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF2UpLeft.TabIndex = 151;
            this.textBox_CSS05_BF2UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_BF2UpRight
            // 
            this.textBox_CSS05_BF2UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF2UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF2UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF2UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF2UpRight.Location = new System.Drawing.Point(227, 115);
            this.textBox_CSS05_BF2UpRight.Name = "textBox_CSS05_BF2UpRight";
            this.textBox_CSS05_BF2UpRight.ReadOnly = true;
            this.textBox_CSS05_BF2UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF2UpRight.TabIndex = 150;
            this.textBox_CSS05_BF2UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label180.ForeColor = System.Drawing.Color.White;
            this.label180.Location = new System.Drawing.Point(71, 100);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(72, 12);
            this.label180.TabIndex = 149;
            this.label180.Text = "BF2_Down";
            // 
            // textBox_CSS05_BF2DownLeft
            // 
            this.textBox_CSS05_BF2DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF2DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF2DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF2DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF2DownLeft.Location = new System.Drawing.Point(73, 142);
            this.textBox_CSS05_BF2DownLeft.Name = "textBox_CSS05_BF2DownLeft";
            this.textBox_CSS05_BF2DownLeft.ReadOnly = true;
            this.textBox_CSS05_BF2DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF2DownLeft.TabIndex = 148;
            this.textBox_CSS05_BF2DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_BF2DownRight
            // 
            this.textBox_CSS05_BF2DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF2DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF2DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF2DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF2DownRight.Location = new System.Drawing.Point(73, 115);
            this.textBox_CSS05_BF2DownRight.Name = "textBox_CSS05_BF2DownRight";
            this.textBox_CSS05_BF2DownRight.ReadOnly = true;
            this.textBox_CSS05_BF2DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF2DownRight.TabIndex = 147;
            this.textBox_CSS05_BF2DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label181.ForeColor = System.Drawing.Color.White;
            this.label181.Location = new System.Drawing.Point(225, 17);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(53, 12);
            this.label181.TabIndex = 146;
            this.label181.Text = "BF1_Up";
            // 
            // textBox_CSS05_BF1UpLeft
            // 
            this.textBox_CSS05_BF1UpLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF1UpLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF1UpLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF1UpLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF1UpLeft.Location = new System.Drawing.Point(227, 59);
            this.textBox_CSS05_BF1UpLeft.Name = "textBox_CSS05_BF1UpLeft";
            this.textBox_CSS05_BF1UpLeft.ReadOnly = true;
            this.textBox_CSS05_BF1UpLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF1UpLeft.TabIndex = 145;
            this.textBox_CSS05_BF1UpLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_BF1UpRight
            // 
            this.textBox_CSS05_BF1UpRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF1UpRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF1UpRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF1UpRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF1UpRight.Location = new System.Drawing.Point(227, 32);
            this.textBox_CSS05_BF1UpRight.Name = "textBox_CSS05_BF1UpRight";
            this.textBox_CSS05_BF1UpRight.ReadOnly = true;
            this.textBox_CSS05_BF1UpRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF1UpRight.TabIndex = 144;
            this.textBox_CSS05_BF1UpRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label182.ForeColor = System.Drawing.Color.White;
            this.label182.Location = new System.Drawing.Point(32, 64);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(29, 12);
            this.label182.TabIndex = 143;
            this.label182.Text = "Left";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label183.ForeColor = System.Drawing.Color.White;
            this.label183.Location = new System.Drawing.Point(32, 37);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(38, 12);
            this.label183.TabIndex = 142;
            this.label183.Text = "Right";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label184.ForeColor = System.Drawing.Color.White;
            this.label184.Location = new System.Drawing.Point(71, 17);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(72, 12);
            this.label184.TabIndex = 141;
            this.label184.Text = "BF1_Down";
            // 
            // textBox_CSS05_BF1DownLeft
            // 
            this.textBox_CSS05_BF1DownLeft.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF1DownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF1DownLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF1DownLeft.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF1DownLeft.Location = new System.Drawing.Point(73, 59);
            this.textBox_CSS05_BF1DownLeft.Name = "textBox_CSS05_BF1DownLeft";
            this.textBox_CSS05_BF1DownLeft.ReadOnly = true;
            this.textBox_CSS05_BF1DownLeft.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF1DownLeft.TabIndex = 140;
            this.textBox_CSS05_BF1DownLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CSS05_BF1DownRight
            // 
            this.textBox_CSS05_BF1DownRight.BackColor = System.Drawing.Color.Black;
            this.textBox_CSS05_BF1DownRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CSS05_BF1DownRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CSS05_BF1DownRight.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CSS05_BF1DownRight.Location = new System.Drawing.Point(73, 32);
            this.textBox_CSS05_BF1DownRight.Name = "textBox_CSS05_BF1DownRight";
            this.textBox_CSS05_BF1DownRight.ReadOnly = true;
            this.textBox_CSS05_BF1DownRight.Size = new System.Drawing.Size(100, 21);
            this.textBox_CSS05_BF1DownRight.TabIndex = 139;
            this.textBox_CSS05_BF1DownRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 97);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 96;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // checkBox_DateSelect
            // 
            this.checkBox_DateSelect.AutoSize = true;
            this.checkBox_DateSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_DateSelect.ForeColor = System.Drawing.Color.White;
            this.checkBox_DateSelect.Location = new System.Drawing.Point(12, 69);
            this.checkBox_DateSelect.Name = "checkBox_DateSelect";
            this.checkBox_DateSelect.Size = new System.Drawing.Size(81, 16);
            this.checkBox_DateSelect.TabIndex = 97;
            this.checkBox_DateSelect.Text = "날짜 선택";
            this.checkBox_DateSelect.UseVisualStyleBackColor = true;
            this.checkBox_DateSelect.Click += new System.EventHandler(this.checkBox_DateSelect_Click);
            this.checkBox_DateSelect.MouseLeave += new System.EventHandler(this.checkBox_DateSelect_MouseLeave);
            this.checkBox_DateSelect.MouseHover += new System.EventHandler(this.checkBox_DateSelect_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // txtBox_Eq1_Addr1
            // 
            this.txtBox_Eq1_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq1_Addr1.Location = new System.Drawing.Point(92, 359);
            this.txtBox_Eq1_Addr1.Name = "txtBox_Eq1_Addr1";
            this.txtBox_Eq1_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq1_Addr1.TabIndex = 99;
            this.txtBox_Eq1_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label185.ForeColor = System.Drawing.Color.White;
            this.label185.Location = new System.Drawing.Point(132, 366);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(10, 12);
            this.label185.TabIndex = 100;
            this.label185.Text = ".";
            // 
            // txtBox_Eq1_Addr2
            // 
            this.txtBox_Eq1_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq1_Addr2.Location = new System.Drawing.Point(144, 359);
            this.txtBox_Eq1_Addr2.Name = "txtBox_Eq1_Addr2";
            this.txtBox_Eq1_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq1_Addr2.TabIndex = 101;
            this.txtBox_Eq1_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Eq1_Addr3
            // 
            this.txtBox_Eq1_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq1_Addr3.Location = new System.Drawing.Point(196, 359);
            this.txtBox_Eq1_Addr3.Name = "txtBox_Eq1_Addr3";
            this.txtBox_Eq1_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq1_Addr3.TabIndex = 103;
            this.txtBox_Eq1_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label186.ForeColor = System.Drawing.Color.White;
            this.label186.Location = new System.Drawing.Point(184, 366);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(10, 12);
            this.label186.TabIndex = 102;
            this.label186.Text = ".";
            // 
            // txtBox_Eq1_Addr4
            // 
            this.txtBox_Eq1_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq1_Addr4.Location = new System.Drawing.Point(248, 359);
            this.txtBox_Eq1_Addr4.Name = "txtBox_Eq1_Addr4";
            this.txtBox_Eq1_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq1_Addr4.TabIndex = 105;
            this.txtBox_Eq1_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label187.ForeColor = System.Drawing.Color.White;
            this.label187.Location = new System.Drawing.Point(236, 366);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(10, 12);
            this.label187.TabIndex = 104;
            this.label187.Text = ".";
            // 
            // txtBox_Eq2_Addr4
            // 
            this.txtBox_Eq2_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq2_Addr4.Location = new System.Drawing.Point(248, 391);
            this.txtBox_Eq2_Addr4.Name = "txtBox_Eq2_Addr4";
            this.txtBox_Eq2_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq2_Addr4.TabIndex = 112;
            this.txtBox_Eq2_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label188.ForeColor = System.Drawing.Color.White;
            this.label188.Location = new System.Drawing.Point(236, 398);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(10, 12);
            this.label188.TabIndex = 111;
            this.label188.Text = ".";
            // 
            // txtBox_Eq2_Addr3
            // 
            this.txtBox_Eq2_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq2_Addr3.Location = new System.Drawing.Point(196, 391);
            this.txtBox_Eq2_Addr3.Name = "txtBox_Eq2_Addr3";
            this.txtBox_Eq2_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq2_Addr3.TabIndex = 110;
            this.txtBox_Eq2_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label189.ForeColor = System.Drawing.Color.White;
            this.label189.Location = new System.Drawing.Point(184, 398);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(10, 12);
            this.label189.TabIndex = 109;
            this.label189.Text = ".";
            // 
            // txtBox_Eq2_Addr2
            // 
            this.txtBox_Eq2_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq2_Addr2.Location = new System.Drawing.Point(144, 391);
            this.txtBox_Eq2_Addr2.Name = "txtBox_Eq2_Addr2";
            this.txtBox_Eq2_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq2_Addr2.TabIndex = 108;
            this.txtBox_Eq2_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label190.ForeColor = System.Drawing.Color.White;
            this.label190.Location = new System.Drawing.Point(132, 398);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(10, 12);
            this.label190.TabIndex = 107;
            this.label190.Text = ".";
            // 
            // txtBox_Eq2_Addr1
            // 
            this.txtBox_Eq2_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq2_Addr1.Location = new System.Drawing.Point(92, 391);
            this.txtBox_Eq2_Addr1.Name = "txtBox_Eq2_Addr1";
            this.txtBox_Eq2_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq2_Addr1.TabIndex = 106;
            this.txtBox_Eq2_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Eq4_Addr4
            // 
            this.txtBox_Eq4_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq4_Addr4.Location = new System.Drawing.Point(248, 455);
            this.txtBox_Eq4_Addr4.Name = "txtBox_Eq4_Addr4";
            this.txtBox_Eq4_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq4_Addr4.TabIndex = 126;
            this.txtBox_Eq4_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label191.ForeColor = System.Drawing.Color.White;
            this.label191.Location = new System.Drawing.Point(236, 462);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(10, 12);
            this.label191.TabIndex = 125;
            this.label191.Text = ".";
            // 
            // txtBox_Eq4_Addr3
            // 
            this.txtBox_Eq4_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq4_Addr3.Location = new System.Drawing.Point(196, 455);
            this.txtBox_Eq4_Addr3.Name = "txtBox_Eq4_Addr3";
            this.txtBox_Eq4_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq4_Addr3.TabIndex = 124;
            this.txtBox_Eq4_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label192.ForeColor = System.Drawing.Color.White;
            this.label192.Location = new System.Drawing.Point(184, 462);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(10, 12);
            this.label192.TabIndex = 123;
            this.label192.Text = ".";
            // 
            // txtBox_Eq4_Addr2
            // 
            this.txtBox_Eq4_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq4_Addr2.Location = new System.Drawing.Point(144, 455);
            this.txtBox_Eq4_Addr2.Name = "txtBox_Eq4_Addr2";
            this.txtBox_Eq4_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq4_Addr2.TabIndex = 122;
            this.txtBox_Eq4_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label193.ForeColor = System.Drawing.Color.White;
            this.label193.Location = new System.Drawing.Point(132, 462);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(10, 12);
            this.label193.TabIndex = 121;
            this.label193.Text = ".";
            // 
            // txtBox_Eq4_Addr1
            // 
            this.txtBox_Eq4_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq4_Addr1.Location = new System.Drawing.Point(92, 455);
            this.txtBox_Eq4_Addr1.Name = "txtBox_Eq4_Addr1";
            this.txtBox_Eq4_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq4_Addr1.TabIndex = 120;
            this.txtBox_Eq4_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Eq3_Addr4
            // 
            this.txtBox_Eq3_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq3_Addr4.Location = new System.Drawing.Point(248, 423);
            this.txtBox_Eq3_Addr4.Name = "txtBox_Eq3_Addr4";
            this.txtBox_Eq3_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq3_Addr4.TabIndex = 119;
            this.txtBox_Eq3_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label194.ForeColor = System.Drawing.Color.White;
            this.label194.Location = new System.Drawing.Point(236, 430);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(10, 12);
            this.label194.TabIndex = 118;
            this.label194.Text = ".";
            // 
            // txtBox_Eq3_Addr3
            // 
            this.txtBox_Eq3_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq3_Addr3.Location = new System.Drawing.Point(196, 423);
            this.txtBox_Eq3_Addr3.Name = "txtBox_Eq3_Addr3";
            this.txtBox_Eq3_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq3_Addr3.TabIndex = 117;
            this.txtBox_Eq3_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label195.ForeColor = System.Drawing.Color.White;
            this.label195.Location = new System.Drawing.Point(184, 430);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(10, 12);
            this.label195.TabIndex = 116;
            this.label195.Text = ".";
            // 
            // txtBox_Eq3_Addr2
            // 
            this.txtBox_Eq3_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq3_Addr2.Location = new System.Drawing.Point(144, 423);
            this.txtBox_Eq3_Addr2.Name = "txtBox_Eq3_Addr2";
            this.txtBox_Eq3_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq3_Addr2.TabIndex = 115;
            this.txtBox_Eq3_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label196.ForeColor = System.Drawing.Color.White;
            this.label196.Location = new System.Drawing.Point(132, 430);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(10, 12);
            this.label196.TabIndex = 114;
            this.label196.Text = ".";
            // 
            // txtBox_Eq3_Addr1
            // 
            this.txtBox_Eq3_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq3_Addr1.Location = new System.Drawing.Point(92, 423);
            this.txtBox_Eq3_Addr1.Name = "txtBox_Eq3_Addr1";
            this.txtBox_Eq3_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq3_Addr1.TabIndex = 113;
            this.txtBox_Eq3_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Eq6_Addr4
            // 
            this.txtBox_Eq6_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq6_Addr4.Location = new System.Drawing.Point(248, 519);
            this.txtBox_Eq6_Addr4.Name = "txtBox_Eq6_Addr4";
            this.txtBox_Eq6_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq6_Addr4.TabIndex = 140;
            this.txtBox_Eq6_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label197.ForeColor = System.Drawing.Color.White;
            this.label197.Location = new System.Drawing.Point(236, 526);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(10, 12);
            this.label197.TabIndex = 139;
            this.label197.Text = ".";
            // 
            // txtBox_Eq6_Addr3
            // 
            this.txtBox_Eq6_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq6_Addr3.Location = new System.Drawing.Point(196, 519);
            this.txtBox_Eq6_Addr3.Name = "txtBox_Eq6_Addr3";
            this.txtBox_Eq6_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq6_Addr3.TabIndex = 138;
            this.txtBox_Eq6_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label198.ForeColor = System.Drawing.Color.White;
            this.label198.Location = new System.Drawing.Point(184, 526);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(10, 12);
            this.label198.TabIndex = 137;
            this.label198.Text = ".";
            // 
            // txtBox_Eq6_Addr2
            // 
            this.txtBox_Eq6_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq6_Addr2.Location = new System.Drawing.Point(144, 519);
            this.txtBox_Eq6_Addr2.Name = "txtBox_Eq6_Addr2";
            this.txtBox_Eq6_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq6_Addr2.TabIndex = 136;
            this.txtBox_Eq6_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label199.ForeColor = System.Drawing.Color.White;
            this.label199.Location = new System.Drawing.Point(132, 526);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(10, 12);
            this.label199.TabIndex = 135;
            this.label199.Text = ".";
            // 
            // txtBox_Eq6_Addr1
            // 
            this.txtBox_Eq6_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq6_Addr1.Location = new System.Drawing.Point(92, 519);
            this.txtBox_Eq6_Addr1.Name = "txtBox_Eq6_Addr1";
            this.txtBox_Eq6_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq6_Addr1.TabIndex = 134;
            this.txtBox_Eq6_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Eq5_Addr4
            // 
            this.txtBox_Eq5_Addr4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq5_Addr4.Location = new System.Drawing.Point(248, 487);
            this.txtBox_Eq5_Addr4.Name = "txtBox_Eq5_Addr4";
            this.txtBox_Eq5_Addr4.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq5_Addr4.TabIndex = 133;
            this.txtBox_Eq5_Addr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label200.ForeColor = System.Drawing.Color.White;
            this.label200.Location = new System.Drawing.Point(236, 494);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(10, 12);
            this.label200.TabIndex = 132;
            this.label200.Text = ".";
            // 
            // txtBox_Eq5_Addr3
            // 
            this.txtBox_Eq5_Addr3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq5_Addr3.Location = new System.Drawing.Point(196, 487);
            this.txtBox_Eq5_Addr3.Name = "txtBox_Eq5_Addr3";
            this.txtBox_Eq5_Addr3.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq5_Addr3.TabIndex = 131;
            this.txtBox_Eq5_Addr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label201.ForeColor = System.Drawing.Color.White;
            this.label201.Location = new System.Drawing.Point(184, 494);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(10, 12);
            this.label201.TabIndex = 130;
            this.label201.Text = ".";
            // 
            // txtBox_Eq5_Addr2
            // 
            this.txtBox_Eq5_Addr2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq5_Addr2.Location = new System.Drawing.Point(144, 487);
            this.txtBox_Eq5_Addr2.Name = "txtBox_Eq5_Addr2";
            this.txtBox_Eq5_Addr2.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq5_Addr2.TabIndex = 129;
            this.txtBox_Eq5_Addr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label202.ForeColor = System.Drawing.Color.White;
            this.label202.Location = new System.Drawing.Point(132, 494);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(10, 12);
            this.label202.TabIndex = 128;
            this.label202.Text = ".";
            // 
            // txtBox_Eq5_Addr1
            // 
            this.txtBox_Eq5_Addr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Eq5_Addr1.Location = new System.Drawing.Point(92, 487);
            this.txtBox_Eq5_Addr1.Name = "txtBox_Eq5_Addr1";
            this.txtBox_Eq5_Addr1.Size = new System.Drawing.Size(38, 22);
            this.txtBox_Eq5_Addr1.TabIndex = 127;
            this.txtBox_Eq5_Addr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Eq1_Change
            // 
            this.btn_Eq1_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq1_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq1_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq1_Change.Location = new System.Drawing.Point(297, 359);
            this.btn_Eq1_Change.Name = "btn_Eq1_Change";
            this.btn_Eq1_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq1_Change.TabIndex = 141;
            this.btn_Eq1_Change.Tag = "Eq1_C";
            this.btn_Eq1_Change.Text = "변경";
            this.btn_Eq1_Change.UseVisualStyleBackColor = true;
            this.btn_Eq1_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // btn_Eq1_Save
            // 
            this.btn_Eq1_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq1_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq1_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq1_Save.Location = new System.Drawing.Point(341, 359);
            this.btn_Eq1_Save.Name = "btn_Eq1_Save";
            this.btn_Eq1_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq1_Save.TabIndex = 142;
            this.btn_Eq1_Save.Tag = "Eq1_S";
            this.btn_Eq1_Save.Text = "저장";
            this.btn_Eq1_Save.UseVisualStyleBackColor = true;
            this.btn_Eq1_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq2_Save
            // 
            this.btn_Eq2_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq2_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq2_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq2_Save.Location = new System.Drawing.Point(341, 391);
            this.btn_Eq2_Save.Name = "btn_Eq2_Save";
            this.btn_Eq2_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq2_Save.TabIndex = 144;
            this.btn_Eq2_Save.Tag = "Eq2_S";
            this.btn_Eq2_Save.Text = "저장";
            this.btn_Eq2_Save.UseVisualStyleBackColor = true;
            this.btn_Eq2_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq2_Change
            // 
            this.btn_Eq2_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq2_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq2_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq2_Change.Location = new System.Drawing.Point(297, 391);
            this.btn_Eq2_Change.Name = "btn_Eq2_Change";
            this.btn_Eq2_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq2_Change.TabIndex = 143;
            this.btn_Eq2_Change.Tag = "Eq2_C";
            this.btn_Eq2_Change.Text = "변경";
            this.btn_Eq2_Change.UseVisualStyleBackColor = true;
            this.btn_Eq2_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // btn_Eq4_Save
            // 
            this.btn_Eq4_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq4_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq4_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq4_Save.Location = new System.Drawing.Point(341, 455);
            this.btn_Eq4_Save.Name = "btn_Eq4_Save";
            this.btn_Eq4_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq4_Save.TabIndex = 148;
            this.btn_Eq4_Save.Tag = "Eq4_S";
            this.btn_Eq4_Save.Text = "저장";
            this.btn_Eq4_Save.UseVisualStyleBackColor = true;
            this.btn_Eq4_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq4_Change
            // 
            this.btn_Eq4_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq4_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq4_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq4_Change.Location = new System.Drawing.Point(297, 455);
            this.btn_Eq4_Change.Name = "btn_Eq4_Change";
            this.btn_Eq4_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq4_Change.TabIndex = 147;
            this.btn_Eq4_Change.Tag = "Eq4_C";
            this.btn_Eq4_Change.Text = "변경";
            this.btn_Eq4_Change.UseVisualStyleBackColor = true;
            this.btn_Eq4_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // btn_Eq3_Save
            // 
            this.btn_Eq3_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq3_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq3_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq3_Save.Location = new System.Drawing.Point(341, 423);
            this.btn_Eq3_Save.Name = "btn_Eq3_Save";
            this.btn_Eq3_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq3_Save.TabIndex = 146;
            this.btn_Eq3_Save.Tag = "Eq3_S";
            this.btn_Eq3_Save.Text = "저장";
            this.btn_Eq3_Save.UseVisualStyleBackColor = true;
            this.btn_Eq3_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq3_Change
            // 
            this.btn_Eq3_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq3_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq3_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq3_Change.Location = new System.Drawing.Point(297, 423);
            this.btn_Eq3_Change.Name = "btn_Eq3_Change";
            this.btn_Eq3_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq3_Change.TabIndex = 145;
            this.btn_Eq3_Change.Tag = "Eq3_C";
            this.btn_Eq3_Change.Text = "변경";
            this.btn_Eq3_Change.UseVisualStyleBackColor = true;
            this.btn_Eq3_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // btn_Eq6_Save
            // 
            this.btn_Eq6_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq6_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq6_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq6_Save.Location = new System.Drawing.Point(341, 519);
            this.btn_Eq6_Save.Name = "btn_Eq6_Save";
            this.btn_Eq6_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq6_Save.TabIndex = 152;
            this.btn_Eq6_Save.Tag = "Eq6_S";
            this.btn_Eq6_Save.Text = "저장";
            this.btn_Eq6_Save.UseVisualStyleBackColor = true;
            this.btn_Eq6_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq6_Change
            // 
            this.btn_Eq6_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq6_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq6_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq6_Change.Location = new System.Drawing.Point(297, 519);
            this.btn_Eq6_Change.Name = "btn_Eq6_Change";
            this.btn_Eq6_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq6_Change.TabIndex = 151;
            this.btn_Eq6_Change.Tag = "Eq6_C";
            this.btn_Eq6_Change.Text = "변경";
            this.btn_Eq6_Change.UseVisualStyleBackColor = true;
            this.btn_Eq6_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // btn_Eq5_Save
            // 
            this.btn_Eq5_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq5_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq5_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq5_Save.Location = new System.Drawing.Point(341, 487);
            this.btn_Eq5_Save.Name = "btn_Eq5_Save";
            this.btn_Eq5_Save.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq5_Save.TabIndex = 150;
            this.btn_Eq5_Save.Tag = "Eq5_S";
            this.btn_Eq5_Save.Text = "저장";
            this.btn_Eq5_Save.UseVisualStyleBackColor = true;
            this.btn_Eq5_Save.Click += new System.EventHandler(this.btn_Eq1_Save_Click);
            // 
            // btn_Eq5_Change
            // 
            this.btn_Eq5_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eq5_Change.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eq5_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Eq5_Change.Location = new System.Drawing.Point(297, 487);
            this.btn_Eq5_Change.Name = "btn_Eq5_Change";
            this.btn_Eq5_Change.Size = new System.Drawing.Size(38, 22);
            this.btn_Eq5_Change.TabIndex = 149;
            this.btn_Eq5_Change.Tag = "Eq5_C";
            this.btn_Eq5_Change.Text = "변경";
            this.btn_Eq5_Change.UseVisualStyleBackColor = true;
            this.btn_Eq5_Change.Click += new System.EventHandler(this.btn_Eq1_Change_Click);
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label203.ForeColor = System.Drawing.Color.White;
            this.label203.Location = new System.Drawing.Point(90, 336);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(202, 14);
            this.label203.TabIndex = 153;
            this.label203.Text = "[                 Address                 ]";
            // 
            // checkBoxAllSelect
            // 
            this.checkBoxAllSelect.AutoSize = true;
            this.checkBoxAllSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBoxAllSelect.ForeColor = System.Drawing.Color.White;
            this.checkBoxAllSelect.Location = new System.Drawing.Point(12, 336);
            this.checkBoxAllSelect.Name = "checkBoxAllSelect";
            this.checkBoxAllSelect.Size = new System.Drawing.Size(41, 16);
            this.checkBoxAllSelect.TabIndex = 154;
            this.checkBoxAllSelect.Text = "All";
            this.checkBoxAllSelect.UseVisualStyleBackColor = true;
            this.checkBoxAllSelect.Click += new System.EventHandler(this.checkBoxAllSelect_Click);
            // 
            // DataTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(787, 676);
            this.Controls.Add(this.checkBoxAllSelect);
            this.Controls.Add(this.label203);
            this.Controls.Add(this.btn_Eq6_Save);
            this.Controls.Add(this.btn_Eq6_Change);
            this.Controls.Add(this.btn_Eq5_Save);
            this.Controls.Add(this.btn_Eq5_Change);
            this.Controls.Add(this.btn_Eq4_Save);
            this.Controls.Add(this.btn_Eq4_Change);
            this.Controls.Add(this.btn_Eq3_Save);
            this.Controls.Add(this.btn_Eq3_Change);
            this.Controls.Add(this.btn_Eq2_Save);
            this.Controls.Add(this.btn_Eq2_Change);
            this.Controls.Add(this.btn_Eq1_Save);
            this.Controls.Add(this.btn_Eq1_Change);
            this.Controls.Add(this.txtBox_Eq6_Addr4);
            this.Controls.Add(this.label197);
            this.Controls.Add(this.txtBox_Eq6_Addr3);
            this.Controls.Add(this.label198);
            this.Controls.Add(this.txtBox_Eq6_Addr2);
            this.Controls.Add(this.label199);
            this.Controls.Add(this.txtBox_Eq6_Addr1);
            this.Controls.Add(this.txtBox_Eq5_Addr4);
            this.Controls.Add(this.label200);
            this.Controls.Add(this.txtBox_Eq5_Addr3);
            this.Controls.Add(this.label201);
            this.Controls.Add(this.txtBox_Eq5_Addr2);
            this.Controls.Add(this.label202);
            this.Controls.Add(this.txtBox_Eq5_Addr1);
            this.Controls.Add(this.txtBox_Eq4_Addr4);
            this.Controls.Add(this.label191);
            this.Controls.Add(this.txtBox_Eq4_Addr3);
            this.Controls.Add(this.label192);
            this.Controls.Add(this.txtBox_Eq4_Addr2);
            this.Controls.Add(this.label193);
            this.Controls.Add(this.txtBox_Eq4_Addr1);
            this.Controls.Add(this.txtBox_Eq3_Addr4);
            this.Controls.Add(this.label194);
            this.Controls.Add(this.txtBox_Eq3_Addr3);
            this.Controls.Add(this.label195);
            this.Controls.Add(this.txtBox_Eq3_Addr2);
            this.Controls.Add(this.label196);
            this.Controls.Add(this.txtBox_Eq3_Addr1);
            this.Controls.Add(this.txtBox_Eq2_Addr4);
            this.Controls.Add(this.label188);
            this.Controls.Add(this.txtBox_Eq2_Addr3);
            this.Controls.Add(this.label189);
            this.Controls.Add(this.txtBox_Eq2_Addr2);
            this.Controls.Add(this.label190);
            this.Controls.Add(this.txtBox_Eq2_Addr1);
            this.Controls.Add(this.txtBox_Eq1_Addr4);
            this.Controls.Add(this.label187);
            this.Controls.Add(this.txtBox_Eq1_Addr3);
            this.Controls.Add(this.label186);
            this.Controls.Add(this.txtBox_Eq1_Addr2);
            this.Controls.Add(this.label185);
            this.Controls.Add(this.txtBox_Eq1_Addr1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_DateSelect);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.checkBox_CS_S05);
            this.Controls.Add(this.checkBox_CS_S04);
            this.Controls.Add(this.checkBox_CS_S03);
            this.Controls.Add(this.checkBox_CS_S02);
            this.Controls.Add(this.checkBox_CS_S01);
            this.Controls.Add(this.checkBox_CS_01);
            this.Controls.Add(this.checkBox_TimeSet);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.comboBox_Second);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.comboBox_Min);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.comboBox_Hour);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_dataTransferTime);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label_Sts);
            this.Controls.Add(this.label_Ctrl);
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.DoubleBuffered = true;
            this.Name = "DataTransferForm";
            this.Text = "C-Shield Sensor Data Transfer [K5EE]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataTransferForm_FormClosing);
            this.Load += new System.EventHandler(this.DataTransferForm_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage_CS_01.ResumeLayout(false);
            this.tabPage_CS_01.PerformLayout();
            this.tabPage_CS_S01.ResumeLayout(false);
            this.tabPage_CS_S01.PerformLayout();
            this.tabPage_CS_S02.ResumeLayout(false);
            this.tabPage_CS_S02.PerformLayout();
            this.tabPage_CS_S03.ResumeLayout(false);
            this.tabPage_CS_S03.PerformLayout();
            this.tabPage_CS_S04.ResumeLayout(false);
            this.tabPage_CS_S04.PerformLayout();
            this.tabPage_CS_S05.ResumeLayout(false);
            this.tabPage_CS_S05.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Timer Displaytimer;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Label label_Ctrl;
        private System.Windows.Forms.Label label_Sts;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_dataTransferTime;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_Hour;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBox_Min;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBox_Second;
        private System.Windows.Forms.CheckBox checkBox_TimeSet;
        private System.Windows.Forms.CheckBox checkBox_CS_01;
        private System.Windows.Forms.CheckBox checkBox_CS_S01;
        private System.Windows.Forms.CheckBox checkBox_CS_S03;
        private System.Windows.Forms.CheckBox checkBox_CS_S02;
        private System.Windows.Forms.CheckBox checkBox_CS_S05;
        private System.Windows.Forms.CheckBox checkBox_CS_S04;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage_CS_01;
        private System.Windows.Forms.TabPage tabPage_CS_S01;
        private System.Windows.Forms.TabPage tabPage_CS_S02;
        private System.Windows.Forms.TabPage tabPage_CS_S03;
        private System.Windows.Forms.TabPage tabPage_CS_S04;
        private System.Windows.Forms.TabPage tabPage_CS_S05;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_CS01_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CS01_SUSCarrierRight;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_CS01_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CS01_SUSScanRight;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_CS01_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CS01_CU2CarrierRight;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_CS01_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CS01_CU2ScanRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_CS01_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CS01_CU1CarrierRight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_CS01_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CS01_CU1ScanRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_CS01_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CS01_BF2UpRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_CS01_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CS01_BF2DownRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_CS01_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CS01_BF1UpRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CS01_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CS01_BF1DownRight;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox_CSS01_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_SUSCarrierRight;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox_CSS01_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_SUSScanRight;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox_CSS01_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_CU2CarrierRight;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox_CSS01_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_CU2ScanRight;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox_CSS01_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_CU1CarrierRight;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox_CSS01_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_CU1ScanRight;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox_CSS01_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_BF2UpRight;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox textBox_CSS01_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_BF2DownRight;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox textBox_CSS01_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_BF1UpRight;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox_CSS01_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS01_BF1DownRight;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox textBox_CSS02_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_SUSCarrierRight;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox textBox_CSS02_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_SUSScanRight;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox textBox_CSS02_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_CU2CarrierRight;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox textBox_CSS02_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_CU2ScanRight;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox textBox_CSS02_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_CU1CarrierRight;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox textBox_CSS02_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_CU1ScanRight;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox textBox_CSS02_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_BF2UpRight;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox textBox_CSS02_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_BF2DownRight;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox textBox_CSS02_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_BF1UpRight;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox textBox_CSS02_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS02_BF1DownRight;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.TextBox textBox_CSS03_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_SUSCarrierRight;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox textBox_CSS03_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_SUSScanRight;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox textBox_CSS03_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_CU2CarrierRight;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox textBox_CSS03_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_CU2ScanRight;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox textBox_CSS03_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_CU1CarrierRight;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox textBox_CSS03_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_CU1ScanRight;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox textBox_CSS03_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_BF2UpRight;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.TextBox textBox_CSS03_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_BF2DownRight;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.TextBox textBox_CSS03_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_BF1UpRight;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox textBox_CSS03_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS03_BF1DownRight;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.TextBox textBox_CSS04_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_SUSCarrierRight;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.TextBox textBox_CSS04_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_SUSScanRight;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.TextBox textBox_CSS04_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_CU2CarrierRight;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox textBox_CSS04_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_CU2ScanRight;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.TextBox textBox_CSS04_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_CU1CarrierRight;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.TextBox textBox_CSS04_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_CU1ScanRight;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.TextBox textBox_CSS04_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_BF2UpRight;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.TextBox textBox_CSS04_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_BF2DownRight;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.TextBox textBox_CSS04_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_BF1UpRight;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.TextBox textBox_CSS04_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS04_BF1DownRight;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.TextBox textBox_CSS05_SUSCarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_SUSCarrierRight;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.TextBox textBox_CSS05_SUSScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_SUSScanRight;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.TextBox textBox_CSS05_CU2CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_CU2CarrierRight;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.TextBox textBox_CSS05_CU2ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_CU2ScanRight;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.TextBox textBox_CSS05_CU1CarrierLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_CU1CarrierRight;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.TextBox textBox_CSS05_CU1ScanLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_CU1ScanRight;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.TextBox textBox_CSS05_BF2UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_BF2UpRight;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.TextBox textBox_CSS05_BF2DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_BF2DownRight;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.TextBox textBox_CSS05_BF1UpLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_BF1UpRight;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.TextBox textBox_CSS05_BF1DownLeft;
        private System.Windows.Forms.TextBox textBox_CSS05_BF1DownRight;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkBox_DateSelect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_Eq1_Addr1;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.TextBox txtBox_Eq1_Addr2;
        private System.Windows.Forms.TextBox txtBox_Eq1_Addr3;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.TextBox txtBox_Eq1_Addr4;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.TextBox txtBox_Eq2_Addr4;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.TextBox txtBox_Eq2_Addr3;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.TextBox txtBox_Eq2_Addr2;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.TextBox txtBox_Eq2_Addr1;
        private System.Windows.Forms.TextBox txtBox_Eq4_Addr4;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.TextBox txtBox_Eq4_Addr3;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.TextBox txtBox_Eq4_Addr2;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.TextBox txtBox_Eq4_Addr1;
        private System.Windows.Forms.TextBox txtBox_Eq3_Addr4;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.TextBox txtBox_Eq3_Addr3;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.TextBox txtBox_Eq3_Addr2;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.TextBox txtBox_Eq3_Addr1;
        private System.Windows.Forms.TextBox txtBox_Eq6_Addr4;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.TextBox txtBox_Eq6_Addr3;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.TextBox txtBox_Eq6_Addr2;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.TextBox txtBox_Eq6_Addr1;
        private System.Windows.Forms.TextBox txtBox_Eq5_Addr4;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.TextBox txtBox_Eq5_Addr3;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.TextBox txtBox_Eq5_Addr2;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.TextBox txtBox_Eq5_Addr1;
        private System.Windows.Forms.Button btn_Eq1_Change;
        private System.Windows.Forms.Button btn_Eq1_Save;
        private System.Windows.Forms.Button btn_Eq2_Save;
        private System.Windows.Forms.Button btn_Eq2_Change;
        private System.Windows.Forms.Button btn_Eq4_Save;
        private System.Windows.Forms.Button btn_Eq4_Change;
        private System.Windows.Forms.Button btn_Eq3_Save;
        private System.Windows.Forms.Button btn_Eq3_Change;
        private System.Windows.Forms.Button btn_Eq6_Save;
        private System.Windows.Forms.Button btn_Eq6_Change;
        private System.Windows.Forms.Button btn_Eq5_Save;
        private System.Windows.Forms.Button btn_Eq5_Change;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.CheckBox checkBoxAllSelect;
    }
}

