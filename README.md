
# BunifuPictureBoxDemo

[![N|Solid](https://bunifuframework.com/wp-content/uploads/2017/06/Bunifu-framework-logo-web.png)](https://bunifuframework.com/)

This demo shows how to make use of BunifuPictureBox to it's maximum, it has custom properties including

  - **BorderRadius** -Gets or Sets the border radius of the picturebox
  - **IsCircle** - Gets or Sets the IsCircle property of the picturebox for exact amount of radius to height ratio
  - **Type** - Sets the Type of shape the control takes

Advantages of BunifuPictureBox is you can achieve your desired look with a few property changes and also give your project a modern look with round edged images.

**Screenshot**

![Example](https://github.com/k33ptoo/BunifuPictureBoxDemo/blob/master/BunifuPictureBoxDemo/res/imgs/img.png)

# Setting Image for BunifuPictureBox
Apart from the normal way of setting an image from a resource - here are a few ways to set BunifuPictureBox Image.
  - From Url
  - From Database
#### From Url
This can be achieved by using two methods 
- WebClient
```csharp
//initialize your webclient
 System.Net.WebClient webClient = new System.Net.WebClient();

//Download and save your file on form load or button click - whichever you like
  webClient.DownloadFileAsync(new Uri("http://scottdavidoff.com/images/davidoff-portrait.square.hi-res.jpg"), "image.jpg");
//create an event
webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
// set the image when the file download is completed
 private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
{
  //set your image
  bunifuPictureBox1.Image = Image.FromFile("image.jpg");
}
```
You can also set an Image directly by loading
```csharp
 bunifuPictureBox1.LoadAsync("http://scottdavidoff.com/images/davidoff-portrait.square.hi-res.jpg");
```

#### From database
You can achieve this by using this code assuming you have your images saved in **pictures** table and a field called **image** and getting them using **id** value
```csharp

        private Image GetImage(string id)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
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
                        conn.Close();
                        return Image.FromStream(stream);
                    }
                }


            }
        }
```
and then just set your image
```csharp
//provide your id
bunifuPictureBox1.Image = = GetImage("1");
```
How to save the an image to database please see clone the porject and see how it is done.

**Libraries**

MySql.Data.dll

Bunifu.Core.dll

Bunifu.UI.WinForms.BunifuPictureBox.dll

Note : Make sure you add these libraries before testing this app  

**Others**

If you would wish to try fetching the data from the db make sure you setup local server and add the db attached
[Database](https://github.com/k33ptoo/BunifuPictureBoxDemo/blob/master/BunifuPictureBoxDemo/res/db/bunifu_tests.sql)

Buy or try [Bunifu Framework](https://bunifuframework.com/) Today

