namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonOneGuy = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart_one = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ALL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCon = new System.Windows.Forms.Button();
            this.buttonALLDATA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRankchi = new System.Windows.Forms.Button();
            this.buttonRnakEng = new System.Windows.Forms.Button();
            this.buttonRankMath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonALLDATA);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxName);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOneGuy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 598);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(10, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "統計";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(149, 94);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(105, 32);
            this.comboBoxName.TabIndex = 4;
            // 
            // buttonOneGuy
            // 
            this.buttonOneGuy.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOneGuy.Location = new System.Drawing.Point(10, 78);
            this.buttonOneGuy.Name = "buttonOneGuy";
            this.buttonOneGuy.Size = new System.Drawing.Size(133, 62);
            this.buttonOneGuy.TabIndex = 3;
            this.buttonOneGuy.Text = "個別成績";
            this.buttonOneGuy.UseVisualStyleBackColor = true;
            this.buttonOneGuy.Click += new System.EventHandler(this.buttonOneGuy_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart_one);
            this.splitContainer2.Panel1.Controls.Add(this.chart_ALL);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(594, 598);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart_one
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_one.ChartAreas.Add(chartArea5);
            this.chart_one.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart_one.Legends.Add(legend5);
            this.chart_one.Location = new System.Drawing.Point(0, 0);
            this.chart_one.Name = "chart_one";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart_one.Series.Add(series9);
            this.chart_one.Size = new System.Drawing.Size(590, 347);
            this.chart_one.TabIndex = 3;
            this.chart_one.Text = "chart2";
            // 
            // chart_ALL
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_ALL.ChartAreas.Add(chartArea6);
            this.chart_ALL.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart_ALL.Legends.Add(legend6);
            this.chart_ALL.Location = new System.Drawing.Point(0, 0);
            this.chart_ALL.Name = "chart_ALL";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series2";
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series3";
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_ALL.Series.Add(series10);
            this.chart_ALL.Series.Add(series11);
            this.chart_ALL.Series.Add(series12);
            this.chart_ALL.Size = new System.Drawing.Size(590, 347);
            this.chart_ALL.TabIndex = 2;
            this.chart_ALL.Text = "chart_ALL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 239);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonCon
            // 
            this.buttonCon.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCon.Location = new System.Drawing.Point(8, 30);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(133, 62);
            this.buttonCon.TabIndex = 6;
            this.buttonCon.Text = "排名";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // buttonALLDATA
            // 
            this.buttonALLDATA.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonALLDATA.Location = new System.Drawing.Point(10, 10);
            this.buttonALLDATA.Name = "buttonALLDATA";
            this.buttonALLDATA.Size = new System.Drawing.Size(244, 62);
            this.buttonALLDATA.TabIndex = 7;
            this.buttonALLDATA.Text = "顯示所有成績";
            this.buttonALLDATA.UseVisualStyleBackColor = true;
            this.buttonALLDATA.Click += new System.EventHandler(this.buttonALLDATA_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 239);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(547, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonRankMath);
            this.panel2.Controls.Add(this.buttonRnakEng);
            this.panel2.Controls.Add(this.buttonRankchi);
            this.panel2.Controls.Add(this.buttonCon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 141);
            this.panel2.TabIndex = 9;
            // 
            // buttonRankchi
            // 
            this.buttonRankchi.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRankchi.Location = new System.Drawing.Point(214, 16);
            this.buttonRankchi.Name = "buttonRankchi";
            this.buttonRankchi.Size = new System.Drawing.Size(133, 31);
            this.buttonRankchi.TabIndex = 7;
            this.buttonRankchi.Text = "按國文";
            this.buttonRankchi.UseVisualStyleBackColor = true;
            this.buttonRankchi.Click += new System.EventHandler(this.buttonRankchi_Click);
            // 
            // buttonRnakEng
            // 
            this.buttonRnakEng.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRnakEng.Location = new System.Drawing.Point(214, 53);
            this.buttonRnakEng.Name = "buttonRnakEng";
            this.buttonRnakEng.Size = new System.Drawing.Size(133, 31);
            this.buttonRnakEng.TabIndex = 8;
            this.buttonRnakEng.Text = "按英文";
            this.buttonRnakEng.UseVisualStyleBackColor = true;
            this.buttonRnakEng.Click += new System.EventHandler(this.buttonRnakEng_Click);
            // 
            // buttonRankMath
            // 
            this.buttonRankMath.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRankMath.Location = new System.Drawing.Point(214, 90);
            this.buttonRankMath.Name = "buttonRankMath";
            this.buttonRankMath.Size = new System.Drawing.Size(133, 31);
            this.buttonRankMath.TabIndex = 9;
            this.buttonRankMath.Text = "按數學";
            this.buttonRankMath.UseVisualStyleBackColor = true;
            this.buttonRankMath.Click += new System.EventHandler(this.buttonRankMath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 598);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonOneGuy;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ALL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_one;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Button buttonALLDATA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRankMath;
        private System.Windows.Forms.Button buttonRnakEng;
        private System.Windows.Forms.Button buttonRankchi;
    }
}

