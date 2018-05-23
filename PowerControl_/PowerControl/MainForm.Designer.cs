namespace PowerControl
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonHiber = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShutDown.Location = new System.Drawing.Point(36, 15);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(336, 43);
            this.buttonShutDown.TabIndex = 0;
            this.buttonShutDown.Text = "Shut Down";
            this.buttonShutDown.UseVisualStyleBackColor = true;
            this.buttonShutDown.Click += new System.EventHandler(this.ButShutDown_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(36, 63);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(336, 40);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButRestart_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSignOut.Location = new System.Drawing.Point(36, 109);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(336, 38);
            this.buttonSignOut.TabIndex = 2;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.ButSignOut_Click);
            // 
            // buttonHiber
            // 
            this.buttonHiber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonHiber.Location = new System.Drawing.Point(36, 153);
            this.buttonHiber.Name = "buttonHiber";
            this.buttonHiber.Size = new System.Drawing.Size(336, 45);
            this.buttonHiber.TabIndex = 3;
            this.buttonHiber.Text = "Hiber";
            this.buttonHiber.UseVisualStyleBackColor = true;
            this.buttonHiber.Click += new System.EventHandler(this.ButHiber_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLock.Location = new System.Drawing.Point(36, 204);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(336, 48);
            this.buttonLock.TabIndex = 4;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.ButLock_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSleep.Location = new System.Drawing.Point(36, 258);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(336, 40);
            this.buttonSleep.TabIndex = 5;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.ButSleep_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.buttonHiber);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonShutDown);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Power On/Off";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonHiber;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

