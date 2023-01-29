using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public class InternetAccess
    {
       static bool noInternet=false;
        
        public static void GetImageFromInternet(string ItemNumberOnWB, DownloadDataCompletedEventHandler fun)
        {
            bool done = false;
            try
            {
                if (!Directory.Exists(@"Data\img\"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"Data\img\");
                    di.CreateSubdirectory(@"tm\");
                    di.CreateSubdirectory(@"big\");
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(@"Data\img\");
                    di.CreateSubdirectory(@"tm\");
                    di.CreateSubdirectory(@"big\");
                }
            }
            catch (Exception)
            {
                //should log the error
            }
            //downloading the file
            try
            {
                //check if the internet works
                WebClient connectionTest = new WebClient();
                connectionTest.OpenRead("https://www.wildberries.ru/");
                connectionTest.Dispose();
                  try
                        {
                            using (WebClient client = new WebClient())
                            {
                                //string url = "https://images.wbstatic.net/tm/new/" + ItemNumberOnWB.ToString().Remove(ItemNumberOnWB.Length - 4, 4) + "0000" + "/" + ItemNumberOnWB.ToString() + "-1.jpg";

                                //client.DownloadFile(new Uri(url), @"c:\temp\image35.png");
                                // OR 
                                string path = @"Data\img\big\" + ItemNumberOnWB.ToString() + "-1.jpg";
                                if (!File.Exists(path))
                                {
                                    client.DownloadDataCompleted += (sender, eventArgs) =>
                                    {
                                        try
                                        {
                                            byte[] fileDataMedium = eventArgs.Result;
                                            if (!(fileDataMedium.Length == 0))
                                            {
                                                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                                                {
                                                    fileStream.Write(fileDataMedium, 0, fileDataMedium.Length);
                                                }
                                            }
                                            else
                                            {
                                                //ToDo
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            //should log the error
                                        }

                                        client.DownloadDataCompleted += fun;
                                    };
                            int basketNumber = 1;
                            string url = "";
                            while (!done && basketNumber <= 13)
                            {
                                url = "https://basket-" + basketNumber.ToString("D2") + @".wb.ru/vol" + ItemNumberOnWB.Substring(0, 3) + "/part" + ItemNumberOnWB.Substring(0, 5) + @"/" + ItemNumberOnWB.ToString() + @"/images/big/1.jpg";
                                //https://basket-04.wb.ru/vol621/part62121/62121114/images/big/1.jpg
                                HttpWebResponse response = null;
                                var request = (HttpWebRequest)WebRequest.Create(url);
                                request.Method = "HEAD";


                                try
                                {
                                    response = (HttpWebResponse)request.GetResponse();
                                    done = true;
                                }
                                catch (WebException ex)
                                {
                                    done = false;
                                    /* A WebException will be thrown if the status of the response is not `200 OK` */
                                }
                                finally
                                {
                                    // Don't forget to close your response.
                                    if (response != null)
                                    {
                                        response.Close();
                                    }
                                }
                                basketNumber++;
                            }
                            try
                            {
                                client.DownloadDataAsync(new Uri(url));
                            }
                            catch (Exception loopError)
                            {
                               //log the error

                            }
                          }
                        }
                    done = false;
                    using (WebClient client = new WebClient())
                            {
                                //string url = "https://images.wbstatic.net/big/new/" + ItemNumberOnWB.ToString().Remove(ItemNumberOnWB.ToString().Length - 4, 4) + "0000" + "/" + ItemNumberOnWB.ToString() + "-1.jpg";
                                //client.DownloadFile(new Uri(url), @"c:\temp\image35.png");
                                // OR 
                                string path = @"Data\img\tm\" + ItemNumberOnWB.ToString() + "-1.jpg";
                                if (!File.Exists(path))
                                {
                                client.DownloadDataCompleted += fun;
                                client.DownloadDataCompleted += (sender, eventArgs) =>
                                    {
                                        try
                                        {
                                            
                                            byte[]? fileDataBig = eventArgs.Result;
                                            if (!(fileDataBig.Length == 0))
                                            {
                                                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                                                    fileStream.Write(fileDataBig, 0, fileDataBig.Length);

                                            }
                                            else
                                            {
                                                //ToDo
                                            }
                                            //did you receive the data successfully? Place your own condition here. 

                                        }
                                        catch (Exception)
                                        {
                                            //ToDo
                                        }
                                    };

                            int basketNumber = 1;
                            string url = "";
                            while (!done && basketNumber <= 13)
                            {
                                url = "https://basket-" + basketNumber.ToString("D2") + @".wb.ru/vol" + ItemNumberOnWB.Substring(0, 3) + "/part" + ItemNumberOnWB.Substring(0, 5) + @"/" + ItemNumberOnWB.ToString() + @"/images/tm/1.jpg";
                                //https://basket-04.wb.ru/vol621/part62121/62121114/images/big/1.jpg
                                HttpWebResponse response = null;
                                var request = (HttpWebRequest)WebRequest.Create(url);
                                request.Method = "HEAD";


                                try
                                {
                                    response = (HttpWebResponse)request.GetResponse();
                                    done = true;
                                }
                                catch (WebException ex)
                                {
                                    done = false;
                                    /* A WebException will be thrown if the status of the response is not `200 OK` */
                                }
                                finally
                                {
                                    // Don't forget to close your response.
                                    if (response != null)
                                    {
                                        response.Close();
                                    }
                                }
                                basketNumber++;
                            }
                            try
                            {
                                client.DownloadDataAsync(new Uri(url));
                            }
                            catch (Exception loopError)
                            {
                                //log the error

                            }

                        }
                            }
                        }
                        catch (Exception)
                        {
                            //should log the error
                        }
                fun.Invoke(null,null);
            }
            catch (Exception)
            {
                noInternet = true;
                //should log the error
            }
          
        }

        
    }
    }

