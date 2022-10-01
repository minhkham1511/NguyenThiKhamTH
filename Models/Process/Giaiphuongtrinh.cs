namespace NguyenThiKhamBTH.Models.Process
{
    public class Giaiphuongtrinh
    {


        public string Giaiphuongtrinhbacnhat(double hesoA, double hesoB)
        {

            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
            string message = "";
            double x;
            if (hesoA == 0)
            {
                if (hesoB == 0)
                {
                    message = "phuong trinh co vo so  nghiem";
                }
                else
                {
                    message = "phuong trinh vo nghiem";
                }
            }
            else
            {
                x = -hesoB / hesoA;
                message = " phuong trinh co nghiem x :" + x;
            }
            return message;
        }
        public string Giaiphuongtrinhbachai(double heSoA, double heSoB, double heSoC)
        {
            string thongBao = "";
            double delta, x1, x2, x;
            if (heSoA == 0)
            {
                thongBao = Giaiphuongtrinhbacnhat(heSoB, heSoC);

                if (heSoB == 0)
                {
                    if (heSoC == 0)
                    {
                        thongBao = "phuong trinh co vo so nghiem";
                    }
                    else
                    {

                        thongBao = "phuong trinh vo nghiem";
                    }
                }


                else
                {
                    x = -heSoC / heSoB;
                    thongBao = " phuong trinh co nghiem x :" + x;
                }
            }


            else
            {
                delta = heSoB * heSoB - 4 * heSoA * heSoC;
                // tinh nghiệm
                if (delta > 0) {
                    x1 = (-heSoB + Math.Sqrt(delta)) / 2 * heSoA;
                    x2 = (-heSoB - Math.Sqrt(delta)) / 2 * heSoA;
                    thongBao = "phuong trinh co 2 nghiem x1 và x2 là: " + x1 + " va " + x2;

                }
                else if (delta == 0)
                {
                    x = -heSoB / (2 * heSoA);
                    thongBao = "Phuong trinh co nghiem kep x1 = x2 = " + x;

                }
                else
                {
                    thongBao = "Phương trinh vo nghiem";
                }

            
            }
            return thongBao;

        }
    }
}
   
