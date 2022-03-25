using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204126
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {

            //random number
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            //cek null dengan max value
            if (title == "")
                throw new NullReferenceException("title tidak boleh null");
            if (title.Length > 100)
                throw new Exception("panjang text maksimal 100");

            this.title = title;

            
            this.playCount = 0;
        }
        public void IncreasePlayCount(int a) 
        {
            this.playCount = a;
        }

        public void PrintVideoDetails()
        {
            for (int i = 0; i < playCount; i++)
            {
                
                Console.WriteLine(this.id);
                Console.WriteLine(this.title);
                Console.WriteLine(i+1);
            }
             
            
        }

     }
}
