﻿namespace oop_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.btnChangeValue = new System.Windows.Forms.Button();
            this.tbNewValueForProperty = new System.Windows.Forms.TextBox();
            this.cbCarAdd = new System.Windows.Forms.CheckBox();
            this.cbSportCarAdd = new System.Windows.Forms.CheckBox();
            this.cbFamilyCarAdd = new System.Windows.Forms.CheckBox();
            this.cbVolkswagenAdd = new System.Windows.Forms.CheckBox();
            this.cbAudiAdd = new System.Windows.Forms.CheckBox();
            this.cbTruckCarAdd = new System.Windows.Forms.CheckBox();
            this.cbBelarusAdd = new System.Windows.Forms.CheckBox();
            this.btnSerializeText = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupCB = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.LoadPlugin = new System.Windows.Forms.Button();
            this.lblAdeddPlugins = new System.Windows.Forms.Label();
            this.pbPluginImg = new System.Windows.Forms.PictureBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPluginImg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Car",
            "SportCar",
            "FamalyCar",
            "TruckCar",
            "Audi",
            "Volkswagen",
            "Belarus"});
            this.cbClass.Location = new System.Drawing.Point(68, 38);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 0;
            this.cbClass.Text = "Class";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // cbProperty
            // 
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(68, 79);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(121, 21);
            this.cbProperty.TabIndex = 2;
            this.cbProperty.Text = "Property";
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(48, 156);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(75, 23);
            this.btnChangeValue.TabIndex = 3;
            this.btnChangeValue.Text = "Change";
            this.btnChangeValue.UseVisualStyleBackColor = true;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // tbNewValueForProperty
            // 
            this.tbNewValueForProperty.Location = new System.Drawing.Point(68, 115);
            this.tbNewValueForProperty.Name = "tbNewValueForProperty";
            this.tbNewValueForProperty.Size = new System.Drawing.Size(121, 20);
            this.tbNewValueForProperty.TabIndex = 5;
            this.tbNewValueForProperty.Text = "NewValue";
            // 
            // cbCarAdd
            // 
            this.cbCarAdd.AutoSize = true;
            this.cbCarAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCarAdd.Location = new System.Drawing.Point(6, 19);
            this.cbCarAdd.Name = "cbCarAdd";
            this.cbCarAdd.Size = new System.Drawing.Size(42, 17);
            this.cbCarAdd.TabIndex = 6;
            this.cbCarAdd.Text = "Car";
            this.cbCarAdd.UseVisualStyleBackColor = false;
            // 
            // cbSportCarAdd
            // 
            this.cbSportCarAdd.AutoSize = true;
            this.cbSportCarAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSportCarAdd.Location = new System.Drawing.Point(54, 19);
            this.cbSportCarAdd.Name = "cbSportCarAdd";
            this.cbSportCarAdd.Size = new System.Drawing.Size(67, 17);
            this.cbSportCarAdd.TabIndex = 7;
            this.cbSportCarAdd.Text = "SportCar";
            this.cbSportCarAdd.UseVisualStyleBackColor = false;
            // 
            // cbFamilyCarAdd
            // 
            this.cbFamilyCarAdd.AutoSize = true;
            this.cbFamilyCarAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbFamilyCarAdd.Location = new System.Drawing.Point(21, 42);
            this.cbFamilyCarAdd.Name = "cbFamilyCarAdd";
            this.cbFamilyCarAdd.Size = new System.Drawing.Size(71, 17);
            this.cbFamilyCarAdd.TabIndex = 8;
            this.cbFamilyCarAdd.Text = "FamilyCar";
            this.cbFamilyCarAdd.UseVisualStyleBackColor = false;
            // 
            // cbVolkswagenAdd
            // 
            this.cbVolkswagenAdd.AutoSize = true;
            this.cbVolkswagenAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbVolkswagenAdd.Location = new System.Drawing.Point(86, 65);
            this.cbVolkswagenAdd.Name = "cbVolkswagenAdd";
            this.cbVolkswagenAdd.Size = new System.Drawing.Size(84, 17);
            this.cbVolkswagenAdd.TabIndex = 11;
            this.cbVolkswagenAdd.Text = "Volkswagen";
            this.cbVolkswagenAdd.UseVisualStyleBackColor = false;
            // 
            // cbAudiAdd
            // 
            this.cbAudiAdd.AutoSize = true;
            this.cbAudiAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbAudiAdd.Location = new System.Drawing.Point(33, 65);
            this.cbAudiAdd.Name = "cbAudiAdd";
            this.cbAudiAdd.Size = new System.Drawing.Size(47, 17);
            this.cbAudiAdd.TabIndex = 10;
            this.cbAudiAdd.Text = "Audi";
            this.cbAudiAdd.UseVisualStyleBackColor = false;
            // 
            // cbTruckCarAdd
            // 
            this.cbTruckCarAdd.AutoSize = true;
            this.cbTruckCarAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbTruckCarAdd.Location = new System.Drawing.Point(98, 42);
            this.cbTruckCarAdd.Name = "cbTruckCarAdd";
            this.cbTruckCarAdd.Size = new System.Drawing.Size(70, 17);
            this.cbTruckCarAdd.TabIndex = 9;
            this.cbTruckCarAdd.Text = "TruckCar";
            this.cbTruckCarAdd.UseVisualStyleBackColor = false;
            // 
            // cbBelarusAdd
            // 
            this.cbBelarusAdd.AutoSize = true;
            this.cbBelarusAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbBelarusAdd.Location = new System.Drawing.Point(127, 19);
            this.cbBelarusAdd.Name = "cbBelarusAdd";
            this.cbBelarusAdd.Size = new System.Drawing.Size(61, 17);
            this.cbBelarusAdd.TabIndex = 12;
            this.cbBelarusAdd.Text = "Belarus";
            this.cbBelarusAdd.UseVisualStyleBackColor = false;
            // 
            // btnSerializeText
            // 
            this.btnSerializeText.Location = new System.Drawing.Point(88, 332);
            this.btnSerializeText.Name = "btnSerializeText";
            this.btnSerializeText.Size = new System.Drawing.Size(75, 23);
            this.btnSerializeText.TabIndex = 13;
            this.btnSerializeText.Text = "Serialize";
            this.btnSerializeText.UseVisualStyleBackColor = true;
            this.btnSerializeText.Click += new System.EventHandler(this.btnSerializeText_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(329, 334);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 14;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(338, 221);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "STATUS:";
            // 
            // groupCB
            // 
            this.groupCB.Controls.Add(this.cbCarAdd);
            this.groupCB.Controls.Add(this.cbSportCarAdd);
            this.groupCB.Controls.Add(this.cbFamilyCarAdd);
            this.groupCB.Controls.Add(this.cbTruckCarAdd);
            this.groupCB.Controls.Add(this.cbVolkswagenAdd);
            this.groupCB.Controls.Add(this.cbBelarusAdd);
            this.groupCB.Controls.Add(this.cbAudiAdd);
            this.groupCB.Location = new System.Drawing.Point(21, 221);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(200, 94);
            this.groupCB.TabIndex = 16;
            this.groupCB.TabStop = false;
            this.groupCB.Text = "Class in List";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(142, 156);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // LoadPlugin
            // 
            this.LoadPlugin.Location = new System.Drawing.Point(329, 156);
            this.LoadPlugin.Name = "LoadPlugin";
            this.LoadPlugin.Size = new System.Drawing.Size(75, 23);
            this.LoadPlugin.TabIndex = 18;
            this.LoadPlugin.Text = "Load Plugin";
            this.LoadPlugin.UseVisualStyleBackColor = true;
            this.LoadPlugin.Click += new System.EventHandler(this.LoadPlugin_Click);
            // 
            // lblAdeddPlugins
            // 
            this.lblAdeddPlugins.AutoSize = true;
            this.lblAdeddPlugins.Location = new System.Drawing.Point(326, 38);
            this.lblAdeddPlugins.Name = "lblAdeddPlugins";
            this.lblAdeddPlugins.Size = new System.Drawing.Size(78, 13);
            this.lblAdeddPlugins.TabIndex = 19;
            this.lblAdeddPlugins.Text = "Added Plugins:";
            // 
            // pbPluginImg
            // 
            this.pbPluginImg.Location = new System.Drawing.Point(476, 38);
            this.pbPluginImg.Name = "pbPluginImg";
            this.pbPluginImg.Size = new System.Drawing.Size(174, 141);
            this.pbPluginImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPluginImg.TabIndex = 20;
            this.pbPluginImg.TabStop = false;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(475, 224);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(175, 20);
            this.tbServerIP.TabIndex = 21;
            this.tbServerIP.Text = "Server IP";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(476, 260);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(174, 20);
            this.tbServerPort.TabIndex = 22;
            this.tbServerPort.Text = "Port ( >1024)";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(475, 295);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(175, 20);
            this.tbFileName.TabIndex = 23;
            this.tbFileName.Text = "File Name (on server)";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(509, 334);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 23);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(582, 334);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(46, 23);
            this.btnGet.TabIndex = 25;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 369);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.tbServerPort);
            this.Controls.Add(this.tbServerIP);
            this.Controls.Add(this.pbPluginImg);
            this.Controls.Add(this.lblAdeddPlugins);
            this.Controls.Add(this.LoadPlugin);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerializeText);
            this.Controls.Add(this.tbNewValueForProperty);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.cbProperty);
            this.Controls.Add(this.cbClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupCB.ResumeLayout(false);
            this.groupCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPluginImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.Button btnChangeValue;
        private System.Windows.Forms.TextBox tbNewValueForProperty;
        private System.Windows.Forms.CheckBox cbCarAdd;
        private System.Windows.Forms.CheckBox cbSportCarAdd;
        private System.Windows.Forms.CheckBox cbFamilyCarAdd;
        private System.Windows.Forms.CheckBox cbVolkswagenAdd;
        private System.Windows.Forms.CheckBox cbAudiAdd;
        private System.Windows.Forms.CheckBox cbTruckCarAdd;
        private System.Windows.Forms.CheckBox cbBelarusAdd;
        private System.Windows.Forms.Button btnSerializeText;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupCB;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button LoadPlugin;
        private System.Windows.Forms.Label lblAdeddPlugins;
        private System.Windows.Forms.PictureBox pbPluginImg;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnGet;
    }
}

