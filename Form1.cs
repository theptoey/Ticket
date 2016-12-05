using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = string.Format(textBox1.Text);// ให้ผู้ใช้ กรอก ชื่อ
            string serName = string.Format(textBox2.Text);// ให้ผู้ใช้ กรอก นามสกุล
            string PhoneNum = string.Format(textBox3.Text);// ให้ผู้ใช้ กรอก เบอร์โทรศัพท์

            label9.Text = comboBox1.Text;// แสงข้อมูลใน ช่องข้อมูลผู้จอง
            label11.Text = comboBox2.Text;// แสงข้อมูลใน ช่องข้อมูลผู้จอง
            label13.Text = textBox1.Text;// แสงข้อมูลใน ช่องข้อมูลผู้จอง
            label16.Text = textBox2.Text;// แสงข้อมูลใน ช่องข้อมูลผู้จอง
            if (textBox3.TextLength >= 10) // คำสั่ง ป้องกันผู้ใช้ กรอกเบอร์โทรเกิน/กรอกไม่ครอบ /หรือลืมกรอก
            {
                label17.Text = textBox3.Text;//
            }
            if (textBox3.TextLength < 10)//
            {
                MessageBox.Show("กรุณา กรอกข้อมูลให้ ครบ");//แจ้งเตือนเมื่อ กรอกไม่ครบ
            }






            if (comboBox2.SelectedIndex == 0 && textBox3.TextLength >= 10)
            {

                label19.Text = ("2200 บาท /ที่นั้ง"); // แสดงราคา /ที่นั่ง
                listBox1.Items.Clear();// คำสั่งเคลียร์ข้อมูล
                listBox1.Items.Add(dateTimePicker1.Text);// แสดงวันเดินทาง



                listBox1.Items.Add("1.30 AM พบกัน ณ จุดนัดหมาย");// แสดงข้อมูลทัวร์
                listBox1.Items.Add("2.00 AM ออกเดินทาง มุ่งหน้าสู่ จ.ตราด โดยรถโค้สบัสของบริษัท");
                listBox1.Items.Add("7.00 AM เดินทาง ถึง จ.ตราด นำทุกทานเข้าสู่ ท่าเรอ แหลมศอก (รับประทานอารเช้าที่ท่าเรือ)");
                listBox1.Items.Add("8.00 AM นัดหมาย เพื่อขึ้นเรือ มุ่งหน้า สู่ เกาะกูด");
                listBox1.Items.Add("9.30 AM เดินทางถึงจุดหมาย นำทุกท่าน เข้าสู่ที่พัก  (โรงแรมระดับ 3 ดาว)");
                listBox1.Items.Add("12.00 PM พักรับประทานอาหาร ที่ห้องอาร ของโรงแรม");
                listBox1.Items.Add("1.00 PM เราจะพาทุกคนไปชม น้ำตกคลองเจ้า และกราบสักการะ พระปรมาพิไธย์ ");
                listBox1.Items.Add("ของพระบาทสมเด็จ พระมงกุฏเกล้า เจ้าอยู่หัว");
                listBox1.Items.Add("3.00 PM เดินทางกลับที่พัก และ พักผ่อนตามอัธยาศัย ให้ท่านได้ชมความสวยงามของชายหาด");
                listBox1.Items.Add("6.00 PM รับประทาน อารเย็น ที่ห้องอาหารของโรงแรม");
                listBox1.Items.Add("----------------------------------------------------------");
                dateTimePicker1.Value.AddDays(1);// แสดง วันเดินทาง

                listBox1.Items.Add("7.00 AM รับแสงอรุณ ยามเช้า");// รายละเอียดทัวร์
                listBox1.Items.Add("8.00 AM รับประทานอาหารที่ห้องอาหาร ของ โรงแรม");
                listBox1.Items.Add("9.00 AM พาทุกท่าน ล่องเรือ ดำน้ำดูปะการัง");
                listBox1.Items.Add("12.00 PM รับประทานอาหาร กลางวัน");
                listBox1.Items.Add("1.00 PM พักผ่อนตามอัธยาศัย เพลิดเพลิน กับการอาบแดด และเล่นน้ำทะเล");
                listBox1.Items.Add("7.00 PM บริการ อารค่ำริมชายหาด ของโรงแรม มีอาหารทะเลปิ่ง ย่าง ดื่มด่ำ กับบรรนากาศ ริมทะเล");

                if (comboBox3.SelectedItem.ToString() == "1 วัน")//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                {
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");
                    dateTimePicker2.Value = DateTime.Today.AddDays(1);//
                    listBox1.Items.Add(temp);//
                }
                if (comboBox3.SelectedItem.ToString() == "2 วัน")//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                
                    {
                    DateTime time = new DateTime();
                    int month = time.Month;
                    int year = time.Year;
                    listBox1.Items.Add("วันที่ " + time.AddDays(2) + " เดือน " + month + " ปี " + year);
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");
                    dateTimePicker2.Value = DateTime.Today.AddDays(2);
                    listBox1.Items.Add(temp);
                   
                }

                listBox1.Items.Add("เดินทางกลับ");

            }

            if (comboBox2.SelectedIndex == 1)
            {

                label19.Text = ("2800 บาท /ที่นั้ง ");//แสดง ราคา
                listBox1.Items.Clear(); // คำสั่งเคลียร์ list box
                listBox1.Items.Add(dateTimePicker1.Text);

                listBox1.Items.Add("18.30 ออกเดินทาง สู่ จ.อบุลราชธานี");// รายละเอียดทัวร์
                listBox1.Items.Add("--------------------------------------");

                
                listBox1.Items.Add("6.00 ถึง จ.อุบลราชธานี");
                listBox1.Items.Add("6.30 พาเข้าด่าน ช่องเม็ง ประตูสู่ ประเทศลาวตอนใต้");
                listBox1.Items.Add("ข้าม สะพาน เข้าสู่ เมืองปากเซ");
                if (comboBox3.SelectedItem.ToString() == "1 วัน")
                {
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                    
                        dateTimePicker2.Value = DateTime.Today.AddDays(1);
                    listBox1.Items.Add(temp);
                }
                if (comboBox3.SelectedItem.ToString() == "2 วัน")//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                {
                    DateTime time = new DateTime();
                    int month = time.Month;
                    int year = time.Year;
                    listBox1.Items.Add("วันที่ " + time.AddDays(2) + " เดือน " + month + " ปี " + year);
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");
                    dateTimePicker2.Value = DateTime.Today.AddDays(2);
                    listBox1.Items.Add(temp);
                   

                }

                listBox1.Items.Add("เดินทางกลับ");

               

                }




                if (comboBox2.SelectedIndex == 2)
                {
                listBox1.Items.Add(dateTimePicker1.Text);//คำสั่ง ระบุ วันเดิดนทาง
                label19.Text = ("3200 บาท / ที่นั้ง");//คำสั่ง เ ระบุ ราคา
                listBox1.Items.Clear();//คำสั่ง เคลียร์ list box 
                listBox1.Items.Add("ระยอง");//คำสั่ง เเสดง รายละเอียดทัว์
                dateTimePicker1.Value.AddDays(1);//คำสั่ง แสดง วันเดินทาง
                listBox1.Items.Add("ออกเดินทาง สู่ จ. ระยอง");
                    listBox1.Items.Add("ชมเจดีย์กลางน้ำ ที่เกาะ กลางน้ำ   ");
                    listBox1.Items.Add("ชมสวน สมุนไพร สมเด็จพระเทพรัตน์");

                    listBox1.Items.Add("เช็ค อิน เข้าที่พัก  พักผ่อนตามอัทยาศัย");

                
                listBox1.Items.Add("6.00 ถึง จ.อุบลราชธานี");
                listBox1.Items.Add("6.30 พาเข้าด่าน ช่องเม็ง ประตูสู่ ประเทศลาวตอนใต้");
                listBox1.Items.Add("ข้าม สะพาน เข้าสู่ เมืองปากเซ");

                if (comboBox3.SelectedItem.ToString() == "1 วัน")//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                {
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");
                    dateTimePicker2.Value = DateTime.Today.AddDays(1);
                    listBox1.Items.Add(temp);
                }
                if (comboBox3.SelectedItem.ToString() == "2 วัน")//คำสั่ง เมื่อเลือก ระยะเวลาใน combobox 3 วัน เดินทางในปฏิทินจะเลื่อนไปตามที่เลือก
                {
                    DateTime time = new DateTime();
                    int month = time.Month;
                    int year = time.Year;
                    listBox1.Items.Add("วันที่ " + time.AddDays(2) + " เดือน " + month + " ปี " + year);
                    string temp = dateTimePicker1.Value.ToString("วันที่ dd เดือน MM ปี yyyy");
                    dateTimePicker2.Value = DateTime.Today.AddDays(2);
                    listBox1.Items.Add(temp);
                   

                    listBox1.Items.Add("เดินทางกลับ");

                    }

                }
            }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        printPreviewDialog.Document = printDocument;//  คำสั่ง print ใบเสร็จ
        printPreviewDialog.ShowDialog();//คำสั่ง เเสดง ตัวอย่าง ใบเสร็จ
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar < '0' || e.KeyChar > '9')//คำสั่ง ให้ช่องกรอกเบอร์โทร ใส่ได้เฉพาะ ตัวเลข
            {
                if (e.KeyChar != (char)8)
                    {
                    MessageBox.Show("กรุณากรอกเฉพาะตัวเลขเท่านั้น");
                    e.KeyChar =(char )0;
                    
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//คำสั่ง ในช่อง ชื่อ  ใส่ได้เฉพาะ ตัวหนังสือ

        {
            if ((double)e.KeyChar >= 44 && (double)e.KeyChar <= 57)
            {
                MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled =true;
            }
            else if (((double)e.KeyChar >= 48 && (double)e.KeyChar <= 122) || (double)e.KeyChar >= 161
                || (double)e.KeyChar == 8 || (double)e.KeyChar == 13 || (double)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//คำสั่ง ในช่อง ใส่ นามสกุล จะ กรอกได้แค่ตัวหนังสือ
        {
            if ((double)e.KeyChar >= 44 && (double)e.KeyChar <= 57)
            {
                MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (((double)e.KeyChar >= 48 && (double)e.KeyChar <= 122) || (double)e.KeyChar >= 161
                || (double)e.KeyChar == 8 || (double)e.KeyChar == 13 || (double)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบเสร็จรับเงิน", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 200));//คำสั่ง เเสดง ข้อมูล ในใบเสร็จ

            e.Graphics.DrawString("ต้นทาง"+ ":" + label9.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25 ,430));



            e.Graphics.DrawString("ปลายทาง" + ":" + label11.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 460));
          

            e.Graphics.DrawString("ชื่อ" + ":" + label13.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 280));




            e.Graphics.DrawString("สกุล" + ":" + label16.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 320));




            e.Graphics.DrawString("เบอร์โทร" +":"+ label17.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 490));



            e.Graphics.DrawString("ราคา" +""+ label19.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25 ,380));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();//คำสั่ง ออกจากโปรแกรม

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
