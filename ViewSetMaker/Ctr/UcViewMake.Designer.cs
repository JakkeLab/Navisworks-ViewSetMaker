namespace ViewSetMaker.Ctr
{
    partial class UcViewMake
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAddinName = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.lbTemplate = new System.Windows.Forms.Label();
            this.btNewSet = new System.Windows.Forms.Button();
            this.btLoadSet = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSaveAs = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.brProgress = new System.Windows.Forms.ProgressBar();
            this.numBuildingStart = new System.Windows.Forms.TextBox();
            this.lbDongNum = new System.Windows.Forms.Label();
            this.lbBuildingStart = new System.Windows.Forms.Label();
            this.lbBuildingEnd = new System.Windows.Forms.Label();
            this.numBuildingEnd = new System.Windows.Forms.TextBox();
            this.lbStandardFloor = new System.Windows.Forms.Label();
            this.numStandardFloor = new System.Windows.Forms.TextBox();
            this.lbEntranceFloor = new System.Windows.Forms.Label();
            this.lbPlanPositionFloor = new System.Windows.Forms.Label();
            this.numEntranceFloor = new System.Windows.Forms.TextBox();
            this.lbUndergroundFloorNum = new System.Windows.Forms.Label();
            this.lbPlanPositionFloorUnderground = new System.Windows.Forms.Label();
            this.numUndergroundNum = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.lbDeveloperName = new System.Windows.Forms.Label();
            this.lbDebugOnly = new System.Windows.Forms.Label();
            this.tbDebugDongTypeName = new System.Windows.Forms.TextBox();
            this.tbDebugFloorTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDebugFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDebugCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDebugDongValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDebugFloorValue = new System.Windows.Forms.TextBox();
            this.tbDebugMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBHCategory = new System.Windows.Forms.TextBox();
            this.lbDongTypeName = new System.Windows.Forms.Label();
            this.tbBHDongTypeName = new System.Windows.Forms.TextBox();
            this.btSaveCurrentView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStnFloor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEntFloor = new System.Windows.Forms.TextBox();
            this.lbFloornumCat = new System.Windows.Forms.Label();
            this.tbBHFloornumCat = new System.Windows.Forms.TextBox();
            this.btSelectHideforEnt = new System.Windows.Forms.Button();
            this.btSelectHideforStn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAddinName
            // 
            this.lbAddinName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbAddinName.Location = new System.Drawing.Point(3, 3);
            this.lbAddinName.Name = "lbAddinName";
            this.lbAddinName.Size = new System.Drawing.Size(111, 20);
            this.lbAddinName.TabIndex = 0;
            this.lbAddinName.Text = "ViewSetMaker";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTemplateName.Location = new System.Drawing.Point(3, 69);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(229, 21);
            this.txtTemplateName.TabIndex = 1;
            // 
            // lbTemplate
            // 
            this.lbTemplate.AutoSize = true;
            this.lbTemplate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbTemplate.Location = new System.Drawing.Point(3, 46);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(61, 17);
            this.lbTemplate.TabIndex = 2;
            this.lbTemplate.Text = "Template";
            // 
            // btNewSet
            // 
            this.btNewSet.Location = new System.Drawing.Point(3, 96);
            this.btNewSet.Name = "btNewSet";
            this.btNewSet.Size = new System.Drawing.Size(43, 23);
            this.btNewSet.TabIndex = 3;
            this.btNewSet.Text = "New";
            this.btNewSet.UseVisualStyleBackColor = true;
            this.btNewSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.createNewTemplate);
            // 
            // btLoadSet
            // 
            this.btLoadSet.Location = new System.Drawing.Point(47, 96);
            this.btLoadSet.Name = "btLoadSet";
            this.btLoadSet.Size = new System.Drawing.Size(43, 23);
            this.btLoadSet.TabIndex = 4;
            this.btLoadSet.Text = "Load";
            this.btLoadSet.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(122, 96);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(45, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btSaveAs
            // 
            this.btSaveAs.Enabled = false;
            this.btSaveAs.Location = new System.Drawing.Point(168, 96);
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(64, 23);
            this.btSaveAs.TabIndex = 6;
            this.btSaveAs.Text = "Save As";
            this.btSaveAs.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(3, 444);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(229, 118);
            this.txtStatus.TabIndex = 7;
            // 
            // brProgress
            // 
            this.brProgress.Location = new System.Drawing.Point(3, 568);
            this.brProgress.Name = "brProgress";
            this.brProgress.Size = new System.Drawing.Size(229, 23);
            this.brProgress.TabIndex = 8;
            this.brProgress.Tag = "";
            // 
            // numBuildingStart
            // 
            this.numBuildingStart.Enabled = false;
            this.numBuildingStart.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numBuildingStart.Location = new System.Drawing.Point(63, 200);
            this.numBuildingStart.Multiline = true;
            this.numBuildingStart.Name = "numBuildingStart";
            this.numBuildingStart.Size = new System.Drawing.Size(52, 22);
            this.numBuildingStart.TabIndex = 9;
            this.numBuildingStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // lbDongNum
            // 
            this.lbDongNum.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbDongNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDongNum.Location = new System.Drawing.Point(2, 182);
            this.lbDongNum.Name = "lbDongNum";
            this.lbDongNum.Size = new System.Drawing.Size(54, 18);
            this.lbDongNum.TabIndex = 10;
            this.lbDongNum.Text = "동 번호";
            // 
            // lbBuildingStart
            // 
            this.lbBuildingStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBuildingStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbBuildingStart.Location = new System.Drawing.Point(4, 200);
            this.lbBuildingStart.Name = "lbBuildingStart";
            this.lbBuildingStart.Size = new System.Drawing.Size(54, 22);
            this.lbBuildingStart.TabIndex = 11;
            this.lbBuildingStart.Text = "시작";
            this.lbBuildingStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBuildingEnd
            // 
            this.lbBuildingEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBuildingEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbBuildingEnd.Location = new System.Drawing.Point(120, 198);
            this.lbBuildingEnd.Name = "lbBuildingEnd";
            this.lbBuildingEnd.Size = new System.Drawing.Size(56, 24);
            this.lbBuildingEnd.TabIndex = 13;
            this.lbBuildingEnd.Text = "끝";
            this.lbBuildingEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numBuildingEnd
            // 
            this.numBuildingEnd.Enabled = false;
            this.numBuildingEnd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numBuildingEnd.Location = new System.Drawing.Point(181, 198);
            this.numBuildingEnd.Multiline = true;
            this.numBuildingEnd.Name = "numBuildingEnd";
            this.numBuildingEnd.Size = new System.Drawing.Size(52, 24);
            this.numBuildingEnd.TabIndex = 12;
            this.numBuildingEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // lbStandardFloor
            // 
            this.lbStandardFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStandardFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbStandardFloor.Location = new System.Drawing.Point(128, 391);
            this.lbStandardFloor.Name = "lbStandardFloor";
            this.lbStandardFloor.Size = new System.Drawing.Size(49, 21);
            this.lbStandardFloor.TabIndex = 18;
            this.lbStandardFloor.Text = "기준층";
            this.lbStandardFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numStandardFloor
            // 
            this.numStandardFloor.Enabled = false;
            this.numStandardFloor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numStandardFloor.Location = new System.Drawing.Point(183, 391);
            this.numStandardFloor.Multiline = true;
            this.numStandardFloor.Name = "numStandardFloor";
            this.numStandardFloor.Size = new System.Drawing.Size(49, 21);
            this.numStandardFloor.TabIndex = 17;
            this.numStandardFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // lbEntranceFloor
            // 
            this.lbEntranceFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEntranceFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbEntranceFloor.Location = new System.Drawing.Point(5, 343);
            this.lbEntranceFloor.Name = "lbEntranceFloor";
            this.lbEntranceFloor.Size = new System.Drawing.Size(49, 21);
            this.lbEntranceFloor.TabIndex = 16;
            this.lbEntranceFloor.Text = "출입구";
            this.lbEntranceFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlanPositionFloor
            // 
            this.lbPlanPositionFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbPlanPositionFloor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPlanPositionFloor.Location = new System.Drawing.Point(3, 326);
            this.lbPlanPositionFloor.Name = "lbPlanPositionFloor";
            this.lbPlanPositionFloor.Size = new System.Drawing.Size(95, 17);
            this.lbPlanPositionFloor.TabIndex = 15;
            this.lbPlanPositionFloor.Text = "도면 배치 위치";
            // 
            // numEntranceFloor
            // 
            this.numEntranceFloor.Enabled = false;
            this.numEntranceFloor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numEntranceFloor.Location = new System.Drawing.Point(65, 343);
            this.numEntranceFloor.Multiline = true;
            this.numEntranceFloor.Name = "numEntranceFloor";
            this.numEntranceFloor.Size = new System.Drawing.Size(52, 21);
            this.numEntranceFloor.TabIndex = 14;
            // 
            // lbUndergroundFloorNum
            // 
            this.lbUndergroundFloorNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUndergroundFloorNum.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbUndergroundFloorNum.Location = new System.Drawing.Point(6, 391);
            this.lbUndergroundFloorNum.Name = "lbUndergroundFloorNum";
            this.lbUndergroundFloorNum.Size = new System.Drawing.Size(49, 21);
            this.lbUndergroundFloorNum.TabIndex = 21;
            this.lbUndergroundFloorNum.Text = "최하층";
            this.lbUndergroundFloorNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlanPositionFloorUnderground
            // 
            this.lbPlanPositionFloorUnderground.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbPlanPositionFloorUnderground.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPlanPositionFloorUnderground.Location = new System.Drawing.Point(3, 372);
            this.lbPlanPositionFloorUnderground.Name = "lbPlanPositionFloorUnderground";
            this.lbPlanPositionFloorUnderground.Size = new System.Drawing.Size(105, 17);
            this.lbPlanPositionFloorUnderground.TabIndex = 20;
            this.lbPlanPositionFloorUnderground.Text = "지하주차장 층수";
            // 
            // numUndergroundNum
            // 
            this.numUndergroundNum.Enabled = false;
            this.numUndergroundNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numUndergroundNum.Location = new System.Drawing.Point(65, 391);
            this.numUndergroundNum.Multiline = true;
            this.numUndergroundNum.Name = "numUndergroundNum";
            this.numUndergroundNum.Size = new System.Drawing.Size(52, 21);
            this.numUndergroundNum.TabIndex = 19;
            this.numUndergroundNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // btRun
            // 
            this.btRun.Enabled = false;
            this.btRun.Location = new System.Drawing.Point(3, 415);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(229, 23);
            this.btRun.TabIndex = 23;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.MouseUp += new System.Windows.Forms.MouseEventHandler(this.runCreatingView);
            // 
            // lbDeveloperName
            // 
            this.lbDeveloperName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbDeveloperName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDeveloperName.Location = new System.Drawing.Point(149, 5);
            this.lbDeveloperName.Name = "lbDeveloperName";
            this.lbDeveloperName.Size = new System.Drawing.Size(83, 30);
            this.lbDeveloperName.TabIndex = 24;
            this.lbDeveloperName.Text = "JakkeLab";
            this.lbDeveloperName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDebugOnly
            // 
            this.lbDebugOnly.AutoSize = true;
            this.lbDebugOnly.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbDebugOnly.Location = new System.Drawing.Point(4, 591);
            this.lbDebugOnly.Name = "lbDebugOnly";
            this.lbDebugOnly.Size = new System.Drawing.Size(83, 17);
            this.lbDebugOnly.TabIndex = 26;
            this.lbDebugOnly.Text = "DebugFinder";
            // 
            // tbDebugDongTypeName
            // 
            this.tbDebugDongTypeName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDebugDongTypeName.Location = new System.Drawing.Point(87, 644);
            this.tbDebugDongTypeName.Name = "tbDebugDongTypeName";
            this.tbDebugDongTypeName.Size = new System.Drawing.Size(145, 21);
            this.tbDebugDongTypeName.TabIndex = 25;
            // 
            // tbDebugFloorTypeName
            // 
            this.tbDebugFloorTypeName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDebugFloorTypeName.Location = new System.Drawing.Point(87, 698);
            this.tbDebugFloorTypeName.Name = "tbDebugFloorTypeName";
            this.tbDebugFloorTypeName.Size = new System.Drawing.Size(145, 21);
            this.tbDebugFloorTypeName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(5, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "동 특성명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(4, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "층 특성";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btDebugFind
            // 
            this.btDebugFind.Location = new System.Drawing.Point(4, 750);
            this.btDebugFind.Name = "btDebugFind";
            this.btDebugFind.Size = new System.Drawing.Size(229, 23);
            this.btDebugFind.TabIndex = 30;
            this.btDebugFind.Text = "Find";
            this.btDebugFind.UseVisualStyleBackColor = true;
            this.btDebugFind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btDebugFind_MouseUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(5, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cat";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDebugCategory
            // 
            this.tbDebugCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDebugCategory.Location = new System.Drawing.Point(87, 617);
            this.tbDebugCategory.Name = "tbDebugCategory";
            this.tbDebugCategory.Size = new System.Drawing.Size(145, 21);
            this.tbDebugCategory.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(5, 671);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "동 값";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDebugDongValue
            // 
            this.tbDebugDongValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDebugDongValue.Location = new System.Drawing.Point(87, 671);
            this.tbDebugDongValue.Name = "tbDebugDongValue";
            this.tbDebugDongValue.Size = new System.Drawing.Size(145, 21);
            this.tbDebugDongValue.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(5, 723);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "층 값";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDebugFloorValue
            // 
            this.tbDebugFloorValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDebugFloorValue.Location = new System.Drawing.Point(87, 723);
            this.tbDebugFloorValue.Name = "tbDebugFloorValue";
            this.tbDebugFloorValue.Size = new System.Drawing.Size(145, 21);
            this.tbDebugFloorValue.TabIndex = 35;
            // 
            // tbDebugMessage
            // 
            this.tbDebugMessage.Location = new System.Drawing.Point(4, 779);
            this.tbDebugMessage.Multiline = true;
            this.tbDebugMessage.Name = "tbDebugMessage";
            this.tbDebugMessage.Size = new System.Drawing.Size(229, 97);
            this.tbDebugMessage.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(1, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "BH 카테고리명";
            // 
            // tbBHCategory
            // 
            this.tbBHCategory.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbBHCategory.Location = new System.Drawing.Point(3, 148);
            this.tbBHCategory.Multiline = true;
            this.tbBHCategory.Name = "tbBHCategory";
            this.tbBHCategory.Size = new System.Drawing.Size(111, 22);
            this.tbBHCategory.TabIndex = 38;
            // 
            // lbDongTypeName
            // 
            this.lbDongTypeName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbDongTypeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDongTypeName.Location = new System.Drawing.Point(122, 130);
            this.lbDongTypeName.Name = "lbDongTypeName";
            this.lbDongTypeName.Size = new System.Drawing.Size(92, 18);
            this.lbDongTypeName.TabIndex = 41;
            this.lbDongTypeName.Text = "동번호 특성명";
            // 
            // tbBHDongTypeName
            // 
            this.tbBHDongTypeName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbBHDongTypeName.Location = new System.Drawing.Point(122, 148);
            this.tbBHDongTypeName.Multiline = true;
            this.tbBHDongTypeName.Name = "tbBHDongTypeName";
            this.tbBHDongTypeName.Size = new System.Drawing.Size(109, 22);
            this.tbBHDongTypeName.TabIndex = 40;
            // 
            // btSaveCurrentView
            // 
            this.btSaveCurrentView.Location = new System.Drawing.Point(128, 343);
            this.btSaveCurrentView.Name = "btSaveCurrentView";
            this.btSaveCurrentView.Size = new System.Drawing.Size(105, 23);
            this.btSaveCurrentView.TabIndex = 42;
            this.btSaveCurrentView.Text = "Save View";
            this.btSaveCurrentView.UseVisualStyleBackColor = true;
            this.btSaveCurrentView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btSaveView_MouseUp);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.Location = new System.Drawing.Point(120, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "기준층";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStnFloor
            // 
            this.tbStnFloor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbStnFloor.Location = new System.Drawing.Point(181, 242);
            this.tbStnFloor.Multiline = true;
            this.tbStnFloor.Name = "tbStnFloor";
            this.tbStnFloor.Size = new System.Drawing.Size(52, 24);
            this.tbStnFloor.TabIndex = 46;
            this.tbStnFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(4, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "출입구";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(2, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "층 구분";
            // 
            // tbEntFloor
            // 
            this.tbEntFloor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbEntFloor.Location = new System.Drawing.Point(63, 245);
            this.tbEntFloor.Multiline = true;
            this.tbEntFloor.Name = "tbEntFloor";
            this.tbEntFloor.Size = new System.Drawing.Size(52, 22);
            this.tbEntFloor.TabIndex = 43;
            this.tbEntFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_IsIntOrBack);
            // 
            // lbFloornumCat
            // 
            this.lbFloornumCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFloornumCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbFloornumCat.Location = new System.Drawing.Point(4, 272);
            this.lbFloornumCat.Name = "lbFloornumCat";
            this.lbFloornumCat.Size = new System.Drawing.Size(110, 22);
            this.lbFloornumCat.TabIndex = 49;
            this.lbFloornumCat.Text = "층번호 특성 이름";
            this.lbFloornumCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBHFloornumCat
            // 
            this.tbBHFloornumCat.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbBHFloornumCat.Location = new System.Drawing.Point(120, 272);
            this.tbBHFloornumCat.Multiline = true;
            this.tbBHFloornumCat.Name = "tbBHFloornumCat";
            this.tbBHFloornumCat.Size = new System.Drawing.Size(113, 22);
            this.tbBHFloornumCat.TabIndex = 48;
            // 
            // btSelectHideforEnt
            // 
            this.btSelectHideforEnt.Location = new System.Drawing.Point(4, 297);
            this.btSelectHideforEnt.Name = "btSelectHideforEnt";
            this.btSelectHideforEnt.Size = new System.Drawing.Size(110, 23);
            this.btSelectHideforEnt.TabIndex = 50;
            this.btSelectHideforEnt.Text = "출입구층 기준";
            this.btSelectHideforEnt.UseVisualStyleBackColor = true;
            this.btSelectHideforEnt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideForEnt_MouseUp);
            // 
            // btSelectHideforStn
            // 
            this.btSelectHideforStn.Location = new System.Drawing.Point(120, 297);
            this.btSelectHideforStn.Name = "btSelectHideforStn";
            this.btSelectHideforStn.Size = new System.Drawing.Size(113, 23);
            this.btSelectHideforStn.TabIndex = 51;
            this.btSelectHideforStn.Text = "기준층 기준";
            this.btSelectHideforStn.UseVisualStyleBackColor = true;
            this.btSelectHideforStn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideForStn_MouseUp);
            // 
            // UcViewMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSelectHideforStn);
            this.Controls.Add(this.btSelectHideforEnt);
            this.Controls.Add(this.lbFloornumCat);
            this.Controls.Add(this.tbBHFloornumCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStnFloor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEntFloor);
            this.Controls.Add(this.btSaveCurrentView);
            this.Controls.Add(this.lbDongTypeName);
            this.Controls.Add(this.tbBHDongTypeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbBHCategory);
            this.Controls.Add(this.tbDebugMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDebugFloorValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDebugDongValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDebugCategory);
            this.Controls.Add(this.btDebugFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDebugFloorTypeName);
            this.Controls.Add(this.lbDebugOnly);
            this.Controls.Add(this.tbDebugDongTypeName);
            this.Controls.Add(this.lbDeveloperName);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.lbUndergroundFloorNum);
            this.Controls.Add(this.lbPlanPositionFloorUnderground);
            this.Controls.Add(this.numUndergroundNum);
            this.Controls.Add(this.lbStandardFloor);
            this.Controls.Add(this.numStandardFloor);
            this.Controls.Add(this.lbEntranceFloor);
            this.Controls.Add(this.lbPlanPositionFloor);
            this.Controls.Add(this.numEntranceFloor);
            this.Controls.Add(this.lbBuildingEnd);
            this.Controls.Add(this.numBuildingEnd);
            this.Controls.Add(this.lbBuildingStart);
            this.Controls.Add(this.lbDongNum);
            this.Controls.Add(this.numBuildingStart);
            this.Controls.Add(this.brProgress);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btSaveAs);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoadSet);
            this.Controls.Add(this.btNewSet);
            this.Controls.Add(this.lbTemplate);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.lbAddinName);
            this.Name = "UcViewMake";
            this.Size = new System.Drawing.Size(235, 881);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddinName;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label lbTemplate;
        private System.Windows.Forms.Button btNewSet;
        private System.Windows.Forms.Button btLoadSet;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSaveAs;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ProgressBar brProgress;
        private System.Windows.Forms.TextBox numBuildingStart;
        private System.Windows.Forms.Label lbDongNum;
        private System.Windows.Forms.Label lbBuildingStart;
        private System.Windows.Forms.Label lbBuildingEnd;
        private System.Windows.Forms.TextBox numBuildingEnd;
        private System.Windows.Forms.Label lbStandardFloor;
        private System.Windows.Forms.TextBox numStandardFloor;
        private System.Windows.Forms.Label lbEntranceFloor;
        private System.Windows.Forms.Label lbPlanPositionFloor;
        private System.Windows.Forms.TextBox numEntranceFloor;
        private System.Windows.Forms.Label lbUndergroundFloorNum;
        private System.Windows.Forms.Label lbPlanPositionFloorUnderground;
        private System.Windows.Forms.TextBox numUndergroundNum;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label lbDeveloperName;
        private System.Windows.Forms.Label lbDebugOnly;
        private System.Windows.Forms.TextBox tbDebugDongTypeName;
        private System.Windows.Forms.TextBox tbDebugFloorTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDebugFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDebugCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDebugDongValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDebugFloorValue;
        private System.Windows.Forms.TextBox tbDebugMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBHCategory;
        private System.Windows.Forms.Label lbDongTypeName;
        private System.Windows.Forms.TextBox tbBHDongTypeName;
        private System.Windows.Forms.Button btSaveCurrentView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStnFloor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEntFloor;
        private System.Windows.Forms.Label lbFloornumCat;
        private System.Windows.Forms.TextBox tbBHFloornumCat;
        private System.Windows.Forms.Button btSelectHideforEnt;
        private System.Windows.Forms.Button btSelectHideforStn;
    }
}
