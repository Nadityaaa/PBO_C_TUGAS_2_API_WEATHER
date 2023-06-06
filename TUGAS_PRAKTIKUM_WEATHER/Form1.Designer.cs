namespace TUGAS_PRAKTIKUM_WEATHER
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.city = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.na1 = new System.Windows.Forms.Label();
            this.na2 = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.na4 = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.na3 = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.picboxicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxicon)).BeginInit();
            this.SuspendLayout();
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(137, 127);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(53, 24);
            this.city.TabIndex = 0;
            this.city.Text = "CITY : ";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(199, 122);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(242, 29);
            this.tbCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(470, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(137, 298);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(69, 24);
            this.details.TabIndex = 4;
            this.details.Text = "DETAILS";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(137, 262);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(92, 24);
            this.condition.TabIndex = 5;
            this.condition.Text = "CONDITION";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.Location = new System.Drawing.Point(137, 335);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(88, 24);
            this.sunrise.TabIndex = 6;
            this.sunrise.Text = "SUNRISE : ";
            // 
            // na1
            // 
            this.na1.AutoSize = true;
            this.na1.BackColor = System.Drawing.Color.Transparent;
            this.na1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na1.Location = new System.Drawing.Point(225, 335);
            this.na1.Name = "na1";
            this.na1.Size = new System.Drawing.Size(39, 24);
            this.na1.TabIndex = 7;
            this.na1.Text = "N/A";
            // 
            // na2
            // 
            this.na2.AutoSize = true;
            this.na2.BackColor = System.Drawing.Color.Transparent;
            this.na2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na2.Location = new System.Drawing.Point(225, 368);
            this.na2.Name = "na2";
            this.na2.Size = new System.Drawing.Size(39, 24);
            this.na2.TabIndex = 9;
            this.na2.Text = "N/A";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.Location = new System.Drawing.Point(137, 368);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(80, 24);
            this.sunset.TabIndex = 8;
            this.sunset.Text = "SUNSET : ";
            // 
            // na4
            // 
            this.na4.AutoSize = true;
            this.na4.BackColor = System.Drawing.Color.Transparent;
            this.na4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na4.Location = new System.Drawing.Point(526, 298);
            this.na4.Name = "na4";
            this.na4.Size = new System.Drawing.Size(39, 24);
            this.na4.TabIndex = 13;
            this.na4.Text = "N/A";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.Location = new System.Drawing.Point(405, 298);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(100, 24);
            this.pressure.TabIndex = 12;
            this.pressure.Text = "PRESSURE : ";
            // 
            // na3
            // 
            this.na3.AutoSize = true;
            this.na3.BackColor = System.Drawing.Color.Transparent;
            this.na3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na3.Location = new System.Drawing.Point(526, 262);
            this.na3.Name = "na3";
            this.na3.Size = new System.Drawing.Size(39, 24);
            this.na3.TabIndex = 11;
            this.na3.Text = "N/A";
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.Location = new System.Drawing.Point(405, 262);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(115, 24);
            this.windspeed.TabIndex = 10;
            this.windspeed.Text = "WIND SPEED : ";
            // 
            // picboxicon
            // 
            this.picboxicon.BackColor = System.Drawing.Color.Transparent;
            this.picboxicon.Location = new System.Drawing.Point(141, 165);
            this.picboxicon.Name = "picboxicon";
            this.picboxicon.Size = new System.Drawing.Size(123, 94);
            this.picboxicon.TabIndex = 15;
            this.picboxicon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 463);
            this.Controls.Add(this.picboxicon);
            this.Controls.Add(this.na4);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.na3);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.na2);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.na1);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.details);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.city);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label na1;
        private System.Windows.Forms.Label na2;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label na4;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label na3;
        private System.Windows.Forms.Label windspeed;
        internal System.Windows.Forms.PictureBox picboxicon;
    }
}

