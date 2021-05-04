
namespace OpenMaqro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabelText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mixerIPlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mixerNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuNewKeymap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuOpenKeymap = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSaveKeymap = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionMenuMixerIP = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBacktick = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnOpenStrBracket = new System.Windows.Forms.Button();
            this.btnCloseStrBracket = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnSemicolon = new System.Windows.Forms.Button();
            this.btnApostrophe = new System.Windows.Forms.Button();
            this.btnHashmark = new System.Windows.Forms.Button();
            this.btnBackslash = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnForeslash = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelText,
            this.statusText,
            this.mixerIPlabel,
            this.mixerNameLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 569);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1486, 32);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabelText
            // 
            this.statusLabelText.Name = "statusLabelText";
            this.statusLabelText.Size = new System.Drawing.Size(117, 25);
            this.statusLabelText.Text = "Vision mixer: ";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.ForestGreen;
            this.statusText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(120, 25);
            this.statusText.Text = "CONNECTED";
            // 
            // mixerIPlabel
            // 
            this.mixerIPlabel.Name = "mixerIPlabel";
            this.mixerIPlabel.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.mixerIPlabel.Size = new System.Drawing.Size(258, 25);
            this.mixerIPlabel.Text = "IP: 192.168.10.153";
            // 
            // mixerNameLabel
            // 
            this.mixerNameLabel.Name = "mixerNameLabel";
            this.mixerNameLabel.Size = new System.Drawing.Size(277, 25);
            this.mixerNameLabel.Text = "ATEM 1M/E Production Studio 4K";
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.connectionMenu,
            this.helpMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1486, 33);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuNewKeymap,
            this.toolStripSeparator1,
            this.fileMenuOpenKeymap,
            this.fileMenuSaveKeymap});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 29);
            this.fileMenu.Text = "File";
            // 
            // fileMenuNewKeymap
            // 
            this.fileMenuNewKeymap.Name = "fileMenuNewKeymap";
            this.fileMenuNewKeymap.Size = new System.Drawing.Size(239, 34);
            this.fileMenuNewKeymap.Text = "New Keymap";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // fileMenuOpenKeymap
            // 
            this.fileMenuOpenKeymap.Name = "fileMenuOpenKeymap";
            this.fileMenuOpenKeymap.Size = new System.Drawing.Size(239, 34);
            this.fileMenuOpenKeymap.Text = "Open Keymap...";
            // 
            // fileMenuSaveKeymap
            // 
            this.fileMenuSaveKeymap.Name = "fileMenuSaveKeymap";
            this.fileMenuSaveKeymap.Size = new System.Drawing.Size(239, 34);
            this.fileMenuSaveKeymap.Text = "Save Keymap...";
            // 
            // connectionMenu
            // 
            this.connectionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionMenuMixerIP});
            this.connectionMenu.Name = "connectionMenu";
            this.connectionMenu.Size = new System.Drawing.Size(118, 29);
            this.connectionMenu.Text = "Connection";
            // 
            // connectionMenuMixerIP
            // 
            this.connectionMenuMixerIP.Name = "connectionMenuMixerIP";
            this.connectionMenuMixerIP.Size = new System.Drawing.Size(254, 34);
            this.connectionMenuMixerIP.Text = "Change Mixer IP...";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 29);
            this.helpMenu.Text = "Help";
            // 
            // btnBacktick
            // 
            this.btnBacktick.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBacktick.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBacktick.Location = new System.Drawing.Point(12, 36);
            this.btnBacktick.Name = "btnBacktick";
            this.btnBacktick.Size = new System.Drawing.Size(100, 100);
            this.btnBacktick.TabIndex = 2;
            this.btnBacktick.Text = "`";
            this.btnBacktick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBacktick.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(118, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1\r\n\r\nCAM 1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(224, 36);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2\r\n\r\nCAM 2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(330, 36);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3\r\n\r\nCAM 3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(436, 36);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4\r\n\r\nCAM 4";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(542, 36);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5\r\n\r\nCAM 5";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(648, 36);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6\r\nSUPER\r\nSOURCE";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(754, 36);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7\r\n\r\nVTR 1";
            this.btn7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(860, 36);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8\r\nMEDIA\r\nPLAYR 1";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(966, 36);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9\r\nMEDIA\r\nPLAYR 2";
            this.btn9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn0.Location = new System.Drawing.Point(1072, 36);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 100);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinus.Location = new System.Drawing.Point(1178, 36);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 100);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEquals.Location = new System.Drawing.Point(1284, 36);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(100, 100);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnQ.Location = new System.Drawing.Point(182, 142);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(100, 100);
            this.btnQ.TabIndex = 2;
            this.btnQ.Text = "Q";
            this.btnQ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnW.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnW.Location = new System.Drawing.Point(288, 142);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(100, 100);
            this.btnW.TabIndex = 2;
            this.btnW.Text = "W";
            this.btnW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnE.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnE.Location = new System.Drawing.Point(394, 142);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(100, 100);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "E";
            this.btnE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnR.Location = new System.Drawing.Point(500, 142);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(100, 100);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "R\r\nSSRC PPT 16:9";
            this.btnR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnT.Location = new System.Drawing.Point(606, 142);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(100, 100);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "T\r\nSSRC PPT 4:3";
            this.btnT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnY.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnY.Location = new System.Drawing.Point(712, 142);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(100, 100);
            this.btnY.TabIndex = 2;
            this.btnY.Text = "Y";
            this.btnY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnU.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnU.Location = new System.Drawing.Point(818, 142);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(100, 100);
            this.btnU.TabIndex = 2;
            this.btnU.Text = "U";
            this.btnU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnI.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnI.Location = new System.Drawing.Point(924, 142);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(100, 100);
            this.btnI.TabIndex = 2;
            this.btnI.Text = "I";
            this.btnI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnO.Location = new System.Drawing.Point(1030, 142);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(100, 100);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "O";
            this.btnO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnP.Location = new System.Drawing.Point(1136, 142);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(100, 100);
            this.btnP.TabIndex = 2;
            this.btnP.Text = "P";
            this.btnP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnOpenStrBracket
            // 
            this.btnOpenStrBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOpenStrBracket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenStrBracket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenStrBracket.Location = new System.Drawing.Point(1242, 142);
            this.btnOpenStrBracket.Name = "btnOpenStrBracket";
            this.btnOpenStrBracket.Size = new System.Drawing.Size(100, 100);
            this.btnOpenStrBracket.TabIndex = 2;
            this.btnOpenStrBracket.Text = "[\r\nCG\r\nFEL";
            this.btnOpenStrBracket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenStrBracket.UseVisualStyleBackColor = false;
            // 
            // btnCloseStrBracket
            // 
            this.btnCloseStrBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCloseStrBracket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseStrBracket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseStrBracket.Location = new System.Drawing.Point(1348, 142);
            this.btnCloseStrBracket.Name = "btnCloseStrBracket";
            this.btnCloseStrBracket.Size = new System.Drawing.Size(100, 100);
            this.btnCloseStrBracket.TabIndex = 2;
            this.btnCloseStrBracket.Text = "]\r\nDSK 1\r\nFEL";
            this.btnCloseStrBracket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseStrBracket.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnA.Location = new System.Drawing.Point(210, 248);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(100, 100);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A\r\nADÁS\r\nKEZDÉS";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnS.Location = new System.Drawing.Point(316, 248);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(100, 100);
            this.btnS.TabIndex = 2;
            this.btnS.Text = "S";
            this.btnS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnD.Location = new System.Drawing.Point(422, 248);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(100, 100);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "D\r\nSSRC BAL";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnF.Location = new System.Drawing.Point(528, 248);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(100, 100);
            this.btnF.TabIndex = 2;
            this.btnF.Text = "F\r\nSSRC JOBB";
            this.btnF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnG.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnG.Location = new System.Drawing.Point(634, 248);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(100, 100);
            this.btnG.TabIndex = 2;
            this.btnG.Text = "G";
            this.btnG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnH.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnH.Location = new System.Drawing.Point(740, 248);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(100, 100);
            this.btnH.TabIndex = 2;
            this.btnH.Text = "H";
            this.btnH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnJ.Location = new System.Drawing.Point(846, 248);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(100, 100);
            this.btnJ.TabIndex = 2;
            this.btnJ.Text = "J";
            this.btnJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnK.Location = new System.Drawing.Point(952, 248);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(100, 100);
            this.btnK.TabIndex = 2;
            this.btnK.Text = "K\r\nPPT KEY BOX 16:9";
            this.btnK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnL.Location = new System.Drawing.Point(1058, 248);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(100, 100);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "L\r\nPPT KEY BOX 4:3";
            this.btnL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnL.UseVisualStyleBackColor = false;
            // 
            // btnSemicolon
            // 
            this.btnSemicolon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSemicolon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSemicolon.Location = new System.Drawing.Point(1164, 248);
            this.btnSemicolon.Name = "btnSemicolon";
            this.btnSemicolon.Size = new System.Drawing.Size(100, 100);
            this.btnSemicolon.TabIndex = 2;
            this.btnSemicolon.Text = ";";
            this.btnSemicolon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSemicolon.UseVisualStyleBackColor = true;
            // 
            // btnApostrophe
            // 
            this.btnApostrophe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnApostrophe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApostrophe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApostrophe.Location = new System.Drawing.Point(1270, 248);
            this.btnApostrophe.Name = "btnApostrophe";
            this.btnApostrophe.Size = new System.Drawing.Size(100, 100);
            this.btnApostrophe.TabIndex = 2;
            this.btnApostrophe.Text = "\'\r\nCG\r\nLE";
            this.btnApostrophe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApostrophe.UseVisualStyleBackColor = false;
            // 
            // btnHashmark
            // 
            this.btnHashmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHashmark.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHashmark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHashmark.Location = new System.Drawing.Point(1376, 248);
            this.btnHashmark.Name = "btnHashmark";
            this.btnHashmark.Size = new System.Drawing.Size(100, 100);
            this.btnHashmark.TabIndex = 2;
            this.btnHashmark.Text = "#\r\nDSK 1\r\nLE";
            this.btnHashmark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHashmark.UseVisualStyleBackColor = false;
            // 
            // btnBackslash
            // 
            this.btnBackslash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackslash.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackslash.Location = new System.Drawing.Point(156, 354);
            this.btnBackslash.Name = "btnBackslash";
            this.btnBackslash.Size = new System.Drawing.Size(100, 100);
            this.btnBackslash.TabIndex = 2;
            this.btnBackslash.Text = "\\";
            this.btnBackslash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackslash.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnZ.Location = new System.Drawing.Point(262, 354);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(100, 100);
            this.btnZ.TabIndex = 2;
            this.btnZ.Text = "Z";
            this.btnZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnX.Location = new System.Drawing.Point(368, 354);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(100, 100);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "X\r\n\r\nAUTO";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnC.Location = new System.Drawing.Point(474, 354);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(100, 100);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C\r\n\r\nCUT";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnV.Location = new System.Drawing.Point(580, 354);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(100, 100);
            this.btnV.TabIndex = 2;
            this.btnV.Text = "V";
            this.btnV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnB.Location = new System.Drawing.Point(686, 354);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(100, 100);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnN.Location = new System.Drawing.Point(792, 354);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(100, 100);
            this.btnN.TabIndex = 2;
            this.btnN.Text = "N";
            this.btnN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnM.Location = new System.Drawing.Point(898, 354);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(100, 100);
            this.btnM.TabIndex = 2;
            this.btnM.Text = "M";
            this.btnM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComma.Location = new System.Drawing.Point(1004, 354);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(100, 100);
            this.btnComma.TabIndex = 2;
            this.btnComma.Text = ",\r\nPPT KEY BAL\r\n";
            this.btnComma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComma.UseVisualStyleBackColor = false;
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPeriod.Location = new System.Drawing.Point(1110, 354);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(100, 100);
            this.btnPeriod.TabIndex = 2;
            this.btnPeriod.Text = ".\r\nPPT KEY JOBB";
            this.btnPeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeriod.UseVisualStyleBackColor = false;
            // 
            // btnForeslash
            // 
            this.btnForeslash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForeslash.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnForeslash.Location = new System.Drawing.Point(1216, 354);
            this.btnForeslash.Name = "btnForeslash";
            this.btnForeslash.Size = new System.Drawing.Size(100, 100);
            this.btnForeslash.TabIndex = 2;
            this.btnForeslash.Text = "/";
            this.btnForeslash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForeslash.UseVisualStyleBackColor = true;
            // 
            // btnSpace
            // 
            this.btnSpace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpace.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSpace.Location = new System.Drawing.Point(446, 460);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(606, 100);
            this.btnSpace.TabIndex = 2;
            this.btnSpace.Text = "space";
            this.btnSpace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSpace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 601);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnHashmark);
            this.Controls.Add(this.btnCloseStrBracket);
            this.Controls.Add(this.btnForeslash);
            this.Controls.Add(this.btnApostrophe);
            this.Controls.Add(this.btnOpenStrBracket);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnSemicolon);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnBackslash);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnBacktick);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.MaximumSize = new System.Drawing.Size(1508, 657);
            this.MinimumSize = new System.Drawing.Size(1508, 657);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Maqro";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelText;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripMenuItem connectionMenu;
        private System.Windows.Forms.Button btnBacktick;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnOpenStrBracket;
        private System.Windows.Forms.Button btnCloseStrBracket;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnSemicolon;
        private System.Windows.Forms.Button btnApostrophe;
        private System.Windows.Forms.Button btnHashmark;
        private System.Windows.Forms.Button btnBackslash;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnForeslash;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.ToolStripMenuItem fileMenuNewKeymap;
        private System.Windows.Forms.ToolStripMenuItem fileMenuOpenKeymap;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSaveKeymap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem connectionMenuMixerIP;
        private System.Windows.Forms.ToolStripStatusLabel mixerIPlabel;
        private System.Windows.Forms.ToolStripStatusLabel mixerNameLabel;
    }
}

