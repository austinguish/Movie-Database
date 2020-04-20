namespace 电影数据库
{
    partial class movie_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movie_form));
            this.Poster = new System.Windows.Forms.PictureBox();
            this.Pname = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.Actor = new System.Windows.Forms.Label();
            this.Mdate = new System.Windows.Forms.Label();
            this.Mtype = new System.Windows.Forms.Label();
            this.synthe_rate = new System.Windows.Forms.Label();
            this.Trailer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Mpno = new System.Windows.Forms.Label();
            this.ticket = new System.Windows.Forms.Button();
            this.Income = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trailer)).BeginInit();
            this.SuspendLayout();
            // 
            // Poster
            // 
            this.Poster.Location = new System.Drawing.Point(74, 43);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(205, 286);
            this.Poster.TabIndex = 0;
            this.Poster.TabStop = false;
            this.Poster.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(310, 52);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(62, 29);
            this.Pname.TabIndex = 1;
            this.Pname.Text = "电影名";
            this.Pname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pname.Click += new System.EventHandler(this.Pname_Click);
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(310, 93);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(62, 29);
            this.Director.TabIndex = 3;
            this.Director.Text = "导演：";
            this.Director.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Director.Click += new System.EventHandler(this.label2_Click);
            // 
            // Actor
            // 
            this.Actor.Location = new System.Drawing.Point(310, 132);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(62, 29);
            this.Actor.TabIndex = 4;
            this.Actor.Text = "主演：";
            this.Actor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mdate
            // 
            this.Mdate.Location = new System.Drawing.Point(310, 173);
            this.Mdate.Name = "Mdate";
            this.Mdate.Size = new System.Drawing.Size(62, 29);
            this.Mdate.TabIndex = 5;
            this.Mdate.Text = "上映：";
            this.Mdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mtype
            // 
            this.Mtype.Location = new System.Drawing.Point(310, 212);
            this.Mtype.Name = "Mtype";
            this.Mtype.Size = new System.Drawing.Size(62, 29);
            this.Mtype.TabIndex = 6;
            this.Mtype.Text = "类型：";
            this.Mtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synthe_rate
            // 
            this.synthe_rate.Enabled = false;
            this.synthe_rate.Location = new System.Drawing.Point(74, 369);
            this.synthe_rate.Name = "synthe_rate";
            this.synthe_rate.Size = new System.Drawing.Size(269, 30);
            this.synthe_rate.TabIndex = 8;
            this.synthe_rate.Text = "评分：";
            this.synthe_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.synthe_rate.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // Trailer
            // 
            this.Trailer.Enabled = true;
            this.Trailer.Location = new System.Drawing.Point(465, 263);
            this.Trailer.Name = "Trailer";
            this.Trailer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Trailer.OcxState")));
            this.Trailer.Size = new System.Drawing.Size(347, 230);
            this.Trailer.TabIndex = 9;
            this.Trailer.Enter += new System.EventHandler(this.Trailer_Enter);
            // 
            // Mpno
            // 
            this.Mpno.Location = new System.Drawing.Point(310, 254);
            this.Mpno.Name = "Mpno";
            this.Mpno.Size = new System.Drawing.Size(62, 29);
            this.Mpno.TabIndex = 10;
            this.Mpno.Text = "预告片";
            this.Mpno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticket
            // 
            this.ticket.Location = new System.Drawing.Point(77, 464);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(75, 29);
            this.ticket.TabIndex = 11;
            this.ticket.Text = "票务";
            this.ticket.UseVisualStyleBackColor = true;
            this.ticket.Click += new System.EventHandler(this.ticket_Click);
            // 
            // Income
            // 
            this.Income.Enabled = false;
            this.Income.Location = new System.Drawing.Point(74, 409);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(269, 30);
            this.Income.TabIndex = 12;
            this.Income.Text = "票房：＄";
            this.Income.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 557);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.Mpno);
            this.Controls.Add(this.Trailer);
            this.Controls.Add(this.synthe_rate);
            this.Controls.Add(this.Mtype);
            this.Controls.Add(this.Mdate);
            this.Controls.Add(this.Actor);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.Poster);
            this.Name = "movie_form";
            this.Text = "电影";
            this.Load += new System.EventHandler(this.actor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trailer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Mpno;
        private System.Windows.Forms.Button ticket;
        public System.Windows.Forms.PictureBox Poster;
        public System.Windows.Forms.Label Pname;
        public System.Windows.Forms.Label Director;
        public System.Windows.Forms.Label Actor;
        public System.Windows.Forms.Label Mdate;
        public System.Windows.Forms.Label Mtype;
        public AxWMPLib.AxWindowsMediaPlayer Trailer;
        public System.Windows.Forms.Label synthe_rate;
        public System.Windows.Forms.Label Income;
    }
}