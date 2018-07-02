// ***********************************************************************
// Assembly         : BunifuPictureBoxDemo
// Author           : KeepToo
// Created          : 07-02-2018
//
// Last Modified By : KeepToo
// Last Modified On : 07-02-2018
// ***********************************************************************
// <copyright file="Form1.cs" company="">
//    Bunifu Technologies Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BunifuPictureBoxDemo
{
    /// <summary>
    /// Class Form1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Home : Form
    {

        /// <summary>
        /// The connection string
        /// </summary>
        private string ConnectionString = "server=127.0.0.1;uid=root;password=;database=bunifu_tests;";
        /// <summary>
        /// The web client
        /// </summary>
        System.Net.WebClient webClient = new System.Net.WebClient();


        /// <summary>
        /// Initializes a new instance of the <see cref="Home" /> class.
        /// </summary>
        public Home()
        {
            InitializeComponent();
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
        }

        /// <summary>
        /// Handles the DownloadFileCompleted event of the WebClient control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            bunifuPictureBox1.Image = Image.FromFile("image.jpg");
        }

        /// <summary>
        /// Handles the DownloadFileCompleted event of the webClient1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="AsyncCompletedEventArgs" /> instance containing the event data.</param>
        private void webClient1_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            bunifuPictureBox1.Image = Image.FromFile("image.jpg");
        }

        /// <summary>
        /// Handles the DownloadProgressChanged event of the webClient1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Net.DownloadProgressChangedEventArgs" /> instance containing the event data.</param>
        private void webClient1_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            groupBox1.Text = $"From URL: [{e.ProgressPercentage}]";

        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //load from .net webclient component
             webClient1.DownloadFileAsync(new Uri("http://scottdavidoff.com/images/davidoff-portrait.square.hi-res.jpg"), "image.jpg");

            //load from a custom webclient
            //webClient.DownloadFileAsync(new Uri("http://scottdavidoff.com/images/davidoff-portrait.square.hi-res.jpg"), "image.jpg");

            //load directly to picturebox
            //bunifuPictureBox1.LoadAsync("http://scottdavidoff.com/images/davidoff-portrait.square.hi-res.jpg");
        }



        /// <summary>
        /// Saves the image.
        /// </summary>
        /// <param name="image">The image.</param>
        private void SaveImage(byte[] image)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                //open connection
                conn.Open();

                cmd.CommandText = "INSERT INTO pictures (image) VALUES (?image)";
                cmd.Parameters.AddWithValue("?image", image);
                cmd.ExecuteNonQuery();
                //close when done
                conn.Close();
            }
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Image.</returns>
        private Image GetImage(string id)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                //open connection
                conn.Open();

                cmd.CommandText = "SELECT image FROM pictures WHERE id = ?id";
                cmd.Parameters.AddWithValue("?id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    const int CHUNK_SIZE = 2 * 1024;
                    byte[] buffer = new byte[CHUNK_SIZE];
                    long bytesRead;
                    long fieldOffset = 0;
                    using (var stream = new MemoryStream())
                    {
                        while ((bytesRead = reader.GetBytes(reader.GetOrdinal("image"), fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
                        {
                            stream.Write(buffer, 0, (int)bytesRead);
                            fieldOffset += bytesRead;
                        }
                        //close connection 
                        conn.Close();
                        //return your image here
                        return Image.FromStream(stream);
                    }
                }


            }
        }

        //convert your image to bytes
        /// <summary>
        /// Images to byte array.
        /// </summary>
        /// <param name="imageIn">The image in.</param>
        /// <returns>System.Byte[].</returns>
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //show dialog 
            saveImageDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the FileOk event of the saveImageDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs" /> instance containing the event data.</param>
        private void saveImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                
                SaveImage(ImageToByteArray(Image.FromFile(saveImageDialog.FileName)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Problem saving image: {ex.Message}");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnGetImage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnGetImage_Click(object sender, EventArgs e)
        {
            try
            {
                pbDb.Image = GetImage("1");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Problem getting image: {ex.Message}");
            }
        }
    }
}
