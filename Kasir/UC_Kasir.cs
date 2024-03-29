﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Natural_1.Kasir
{
    public partial class UC_Kasir : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        int clickedBonus = 0;
        int totalTransaksi = 0;
        public UC_Kasir()
        {
            InitializeComponent();
            barang_CB = kasirHelper.loadCBX(barang_CB,"Barang", "Nama", con);
            ongkir_TB.Text = "0";
        }

        

        private void noPelanggan_TB_Enter(object sender, EventArgs e)
        {
            noPelanggan_TB.Text = "";
        }

        private void noPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (noPelanggan_TB.BackColor == Color.Red)
            {
                noPelanggan_TB.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (noPelanggan_TB.Text != null)
                {
                    namaPelanggan_TB.Enabled = false;
                    noTelepon_TB.Enabled = false;
                    alamatPelanggan_TB.Enabled = false;
                    areaPelanggan_TB.Enabled = false;
                    bonusPelanggan_TB.Enabled = false;
                    ambilBonus_BTN.Enabled = false;
                    tambah_BTN.Enabled = false;
                    ambilBonus_BTN.Enabled = true;

                    SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
                    try
                    {
                        SqlCommand cmdd = new SqlCommand($"SELECT Nama , No_Telp, Alamat,Area , Bonus FROM Pelanggan WHERE Id_Pelanggan ='{noPelanggan_TB.Text}' ", con);
                        con.Open();
                        SqlDataReader sdr = cmdd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Pelanggan.Nama = sdr["Nama"].ToString();
                            Pelanggan.Telepon = sdr["No_Telp"].ToString();
                            Pelanggan.Alamat = sdr["Alamat"].ToString();
                            Pelanggan.Area = sdr["Area"].ToString();
                            Pelanggan.Bonus = sdr["Bonus"].ToString();
                        }
                        if (Pelanggan.Nama != null)
                        {
                            namaPelanggan_TB.Text = Pelanggan.Nama.ToString();
                            noTelepon_TB.Text = Pelanggan.Telepon.ToString();
                            alamatPelanggan_TB.Text = Pelanggan.Alamat.ToString();
                            areaPelanggan_TB.Text = Pelanggan.Area.ToString();
                            bonusPelanggan_TB.Text = Pelanggan.Bonus.ToString();
                            barang_CB.Enabled = true;
                        }
                        else
                        {
                            namaPelanggan_TB.Enabled = false;
                            noTelepon_TB.Enabled = false;
                            alamatPelanggan_TB.Enabled = false;
                            areaPelanggan_TB.Enabled = false;
                            bonusPelanggan_TB.Enabled = false;
                            MessageBox.Show("Nomor pelanggan Invalid!");
                            noPelanggan_TB.BackColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message+"\nError at UC_Kasir.cs noPelangganTB_KeyUp","UC_KASIR.cs - noPelangganTB_Keyup");
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }

            }
        }

        private void noPelanggan_TB_Leave(object sender, EventArgs e)
        {
           
        }

        private void baru_BTN_Click(object sender, EventArgs e)
        {
            Pelanggan.Clear();
            con.Close();
            kasirHelper.totalHarga = 0;
            kasir_DGV.Rows.Clear();
            noPelanggan_TB.Clear();
            namaPelanggan_TB.Clear();
            noTelepon_TB.Clear();
            alamatPelanggan_TB.Clear();
            areaPelanggan_TB.Clear();
            bonusPelanggan_TB.Clear();
            noStruk_TB.Clear();
            noStruk_TB.ReadOnly = false;
            pelangganBaru_CB.Enabled = true;
            nonMember_CB.Enabled = true;
            pelangganBaru_CB.Checked = false;
            noPelanggan_TB.Enabled = true;
            gabungData_CB.Enabled = true;
            nonMember_CB.Checked = false;
            kasirHelper.totalHarga = 0;
            barang_CB.Enabled = false;
            D_ItemDibeli.Clear();

        }

        private void pelangganBaru_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (pelangganBaru_CB.Checked == true)
            {
                beliLangsung_BTN.Enabled = true;
                namaPelanggan_TB.Enabled = true;
                alamatPelanggan_TB.Enabled = true;
                areaPelanggan_TB.Enabled = true;
                bonusPelanggan_TB.Enabled = true;
                gabungData_CB.Enabled = false;
                tambah_BTN.Enabled = true;
                noPelanggan_TB.Text = kasirHelper.GenerateNoPelanggan(con);
                bonusPelanggan_TB.Text = "0";


                if (nonMember_CB.Checked == true)
                {
                    noTelepon_TB.Enabled = false;
                    noPelanggan_TB.Enabled = false;
                }
                else
                {
                    noTelepon_TB.Enabled = true;
                    noPelanggan_TB.Enabled = true;
                }
                
            }
            else
            {
                beliLangsung_BTN.Enabled = false;
                namaPelanggan_TB.Enabled = false;
                alamatPelanggan_TB.Enabled = false;
                areaPelanggan_TB.Enabled = false;
                bonusPelanggan_TB.Enabled = false;

                gabungData_CB.Enabled = true;

                beliLangsung_BTN.Enabled = false;
            }
        }

        private void beliLangsung_BTN_Click(object sender, EventArgs e)
        {
            kasir_DGV.Rows.Add();
            try
            {

                //add to Data grid
                int rowIndex = kasir_DGV.Rows.Count - 1;
                kasir_DGV.Rows[rowIndex].Cells[0].Value = barang_CB.Items[0].ToString();
                kasir_DGV.Rows[rowIndex].Cells[1].Value = "-";
                kasir_DGV.Rows[rowIndex].Cells[2].Value = "1";
                kasir_DGV.Rows[rowIndex].Cells[3].Value = barang_CB.SelectedItem.ToString();
                kasir_DGV.Rows[rowIndex].Cells[4].Value = hargaSatuan_TB.Text.ToString();
                kasir_DGV.Rows[rowIndex].Cells[5].Value = Int32.Parse(hargaSatuan_TB.Text.ToString()) * Int32.Parse(jumlah_TB.Text.ToString());

                //disabling buttonand tb cb
                pelangganBaru_CB.Enabled = false;
                nonMember_CB.Enabled = false;
                beliLangsung_BTN.Enabled = false;
                namaPelanggan_TB.Enabled = false;
                alamatPelanggan_TB.Enabled = false;
                areaPelanggan_TB.Enabled = false;
                bonusPelanggan_TB.Enabled = false;
                namaPelanggan2_TB.Enabled = false;
                alamatPelanggan2_TB.Enabled = false;
                areaPelanggan2_TB.Enabled = false;
                bonusPelanggan2_TB.Enabled = false;
                ambilBonus_BTN.Enabled = false;
                tambah_BTN.Enabled = false;
                beli_BTN.Enabled = false;
                hapusbarang_BTN.Enabled = false;
                cetakStruk_BTN.Enabled = true;

                //Adding transaksi into database Log.
                try
                {
                    noStruk_TB.Text = kasirHelper.getNoStruk("Pelanggan", Karyawan.Nama, totalTransaksi);
                    SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam,Operator,NamaPelanggan,Kegiatan,Modul,Pemasukan,Struk) " +
                    $"VALUES('{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}', '{Karyawan.Nama.ToString()}', 'BeliLangsung' ,'Pelanggan', 'Kasir', {kasir_DGV.Rows[rowIndex].Cells[5].Value.ToString()},'{noStruk_TB.Text.ToString()}' " +
                    $" )", con);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        MessageBox.Show("Transaksi berhasil");
                    }
                    ////if (nonMember_CB.Checked != true)
                    ////{
                    ////    kasirHelper.totalHarga += Barang.Harga_PCS * Convert.ToInt32(jumlah_TB.Text.ToString()) + Convert.ToInt32(ongkir_TB.Text.ToString());
                    ////    cmd = new SqlCommand($"INSERT INTO Pelanggan(Id_Pelanggan, Nama, No_Telp, Alamat, Bonus, Area) VALUES" +
                    ////    $"('{noPelanggan_TB.Text.ToString()}', '{namaPelanggan_TB.Text.ToString()}','{noTelepon_TB.Text.ToString()}', '{alamatPelanggan_TB.Text.ToString()}', '{bonusPelanggan_TB.Text.ToString()}', '{areaPelanggan_TB.Text.ToString()}' )", con);
                    ////    cmd.ExecuteNonQuery();
                    ////}

                    //add to baranglog

                    int iRow = kasir_DGV.Rows.Count;
                    for (int i = 0; i < iRow; i++)
                    {
                        //MessageBox.Show(i.ToString(), iRow.ToString());
                        cmd = new SqlCommand($"insert into BarangLog(TglWaktu, NamaBarang, Pengurangan, Pemasukan, Struk, totalHarga) " +
                            $"values( '{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}' , '{kasir_DGV.Rows[i].Cells[0].Value.ToString()}', " +
                            $"'{kasir_DGV.Rows[i].Cells[2].Value.ToString()}', 0, '{noStruk_TB.Text}' , " +
                            $" '{kasir_DGV.Rows[i].Cells[5].Value.ToString()}') ", con);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " insert into baranglog failed", "uckasir beli btn error");
                        }
                    }
                    for (int i = 0; i < iRow; i++)
                    {
                        cmd = new SqlCommand($"update Barang set Jumlah = (select Jumlah from barang where nama = '{kasir_DGV.Rows[i].Cells[0].Value.ToString()}')" +
                            $" -{kasir_DGV.Rows[i].Cells[2].Value.ToString()} where Nama='{kasir_DGV.Rows[i].Cells[0].Value.ToString()}' ", con);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fail to update stock. Error Message : \n" + ex.Message, "UC_KASIR-BELILANGSUNG");
                        }
                    }

                }
                catch (Exception ex)
                {
                    if (jumlah_TB.Text != "")
                    {
                        MessageBox.Show("Isikan Jumlah barang!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message + "\nAT BeliLangsungBTN_Click when try to input data from datagrid into Database Transaction Log", "UC_Kasir.cs-beliLangsungBTN_Click");
                    }
                }
                finally
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                if (jumlah_TB.Text == "")
                {
                    MessageBox.Show("Jumlah barang kosong!");
                    baru_BTN.PerformClick();
                }
                else
                {
                    MessageBox.Show(ex.Message + "\nError at beliLangsung_BTN_Click when pelangganBaru_Cb.Checked==true and\ntrying to add value into datagrid", "UC_Kasir.cs - beliLangsung_BTN_Click Eror");
                }
            }
            totalTransaksi += 1;

        }

        private void nonMember_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (nonMember_CB.Checked == true)
            {
                gabungData_CB.Enabled = false;
                noPelanggan_TB.Enabled = false;
                noTelepon_TB.Enabled = false;
                beli_BTN.Enabled = true;
                tambah_BTN.Enabled = true;
            }
            else
            {
                gabungData_CB.Enabled = true;
                noPelanggan_TB.Enabled = true;
                noTelepon_TB.Enabled = true;
            }
        }

        private void barang_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            kasirHelper.getBarangDetail(con, barang_CB.SelectedItem.ToString());
            hargaSatuan_TB.Text = Barang.Harga_PCS.ToString();
            bonuspertb.Text = Barang.Bonus_PER.ToString();
            stok_tb.Text = Barang.Jumlah.ToString();
            satuan_tb.Text = Barang.Satuan.ToString();
            disTB.Text = Barang.Distributor.ToString();
            if(bonuspertb.Text=="0")
            {
                ambilBonus_BTN.Enabled = false;
            }
            else
            {
                ambilBonus_BTN.Enabled = true;
            }
        }

        private bool checkPelanggan1TB()
        {
            if (nonMember_CB.Checked)
            {
                if (noPelanggan_TB.Text != "" && noTelepon_TB.Text != "" && alamatPelanggan_TB.Text != "" && namaPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (alamatPelanggan_TB.Text != "" && namaPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void tambah_BTN_Click(object sender, EventArgs e)
        {
            if (jumlah_TB.Text != "")
            {
                if (Int32.Parse(jumlah_TB.Text) > 0) {


                    SqlCommand cmd = new SqlCommand($"select jumlah from Barang where Nama = '{barang_CB.SelectedItem.ToString()}'", con);
                    try
                    {
                        con.Close();
                        con.Open();

                        int jmlh = Int32.Parse(cmd.ExecuteScalar().ToString());
                        if (jmlh > Int32.Parse(jumlah_TB.Text))
                        {
                            beliLangsung_BTN.Enabled = false;
                            beli_BTN.Enabled = true;
                            ongkir_TB.Enabled = true;
                            hapusbarang_BTN.Enabled = true;
                            if (bonusPelanggan_TB.Text != null)
                            {
                                ambilBonus_BTN.Enabled = true;
                            }

                            kasir_DGV.Rows.Add();
                            try
                            {

                                //kasir_DGV.Rows[indexRow].Cells
                                int indexRow = kasir_DGV.Rows.Count - 1;
                                kasir_DGV.Rows[indexRow].Cells[0].Value = barang_CB.SelectedItem.ToString();
                                kasir_DGV.Rows[indexRow].Cells[1].Value = "-";
                                kasir_DGV.Rows[indexRow].Cells[2].Value = jumlah_TB.Text.ToString();
                                kasir_DGV.Rows[indexRow].Cells[3].Value = Barang.Satuan;
                                kasir_DGV.Rows[indexRow].Cells[4].Value = hargaSatuan_TB.Text.ToString();
                                kasir_DGV.Rows[indexRow].Cells[5].Value = Int32.Parse(hargaSatuan_TB.Text.ToString()) * Int32.Parse(jumlah_TB.Text.ToString());


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "tambah_BTN_Click when input data to datagrid", "UC_Kasir.cs - tambah_BTN_Click ERROR");
                            }
                        }

                        else
                        {
                            ToolTip tp = new ToolTip();
                            tp.Show("Stok barang kurang!", (Button)sender, 0, -30, 10000);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }


                    
                }

                else
                {
                    ToolTip tp = new ToolTip();
                    tp.Show("Nilai tidak boleh negatif!", (Button)sender, 0, -30, 10000);
                }

                
            }
            else
            {
                MessageBox.Show("Jumlah Textbox Kosong!");
            }

        }

        private void namaPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (e.KeyCode==Keys.Tab)
                    {
                        noTelepon_TB.Focus();
                    }
                }
                else
                {
                    if (e.KeyCode==Keys.Tab)
                    {
                        alamatPelanggan_TB.Focus();
                    }
                }
            }

            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "" && noTelepon_TB.Text != "" && noPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
                else
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void noTelepon_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (e.KeyCode == Keys.Tab)
                    {
                        alamatPelanggan_TB.Focus();
                    }
                }
            }

            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "" && noTelepon_TB.Text != "" && noPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
                else
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (!pelangganBaru_CB.Checked)
                {
                    namaPelanggan_TB.Enabled = true;
                    noTelepon_TB.Enabled = true;
                    alamatPelanggan_TB.Enabled = true;
                    areaPelanggan_TB.Enabled = true;
                    bonusPelanggan_TB.Enabled = true;
                    ambilBonus_BTN.Enabled = true;

                    SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
                    try
                    {
                        SqlCommand cmdd = new SqlCommand($"SELECT Id_Pelanggan, Nama , No_Telp, Alamat,Area , Bonus FROM Pelanggan WHERE No_Telp ='{noTelepon_TB.Text}' ", con);
                        con.Open();
                        SqlDataReader sdr = cmdd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Pelanggan.ID_Pelanggan = sdr["Id_Pelanggan"].ToString();
                            Pelanggan.Nama = sdr["Nama"].ToString();
                            Pelanggan.Telepon = sdr["No_Telp"].ToString();
                            Pelanggan.Alamat = sdr["Alamat"].ToString();
                            Pelanggan.Area = sdr["Area"].ToString();
                            Pelanggan.Bonus = sdr["Bonus"].ToString();
                        }
                        if (Pelanggan.Nama != null)
                        {
                            namaPelanggan_TB.Text = Pelanggan.Nama.ToString();
                            noTelepon_TB.Text = Pelanggan.Telepon.ToString();
                            alamatPelanggan_TB.Text = Pelanggan.Alamat.ToString();
                            areaPelanggan_TB.Text = Pelanggan.Area.ToString();
                            bonusPelanggan_TB.Text = Pelanggan.Bonus.ToString();
                            noPelanggan_TB.Text = Pelanggan.ID_Pelanggan.ToString();
                        }
                        else
                        {
                            namaPelanggan_TB.Enabled = false;
                            noTelepon_TB.Enabled = false;
                            alamatPelanggan_TB.Enabled = false;
                            areaPelanggan_TB.Enabled = false;
                            bonusPelanggan_TB.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message + "\nError at UC_Kasir.cs noPelangganTB_KeyUp", "UC_KASIR.cs - noPelangganTB_Keyup");
                    }
                    finally
                    {
                        con.Close();
                    }
                }


                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }

            }
        }

        private void alamatPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (e.KeyCode == Keys.Tab)
                    {
                        areaPelanggan_TB.Focus();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Tab)
                    {
                        areaPelanggan_TB.Focus();
                    }
                }
            }

            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "" && noTelepon_TB.Text != "" && noPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
                else
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void areaPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if (e.KeyCode == Keys.Tab)
                    {
                        noTelepon_TB.Focus();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Tab)
                    {
                        alamatPelanggan_TB.Focus();
                    }
                }
            }

            if (pelangganBaru_CB.Checked)
            {
                if (nonMember_CB.Checked == false)
                {
                    if(namaPelanggan_TB.Text!=""&&alamatPelanggan_TB.Text!="" &&areaPelanggan_TB.Text!=""&&noTelepon_TB.Text!="" && noPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
                else
                {
                    if (namaPelanggan_TB.Text != "" && alamatPelanggan_TB.Text != "" && areaPelanggan_TB.Text != "")
                    {
                        barang_CB.Enabled = true;
                    }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void beli_BTN_Click(object sender, EventArgs e)
        {
            noStruk_TB.Text = kasirHelper.getNoStruk("Pelanggan", Karyawan.Nama, totalTransaksi+1);
            totalTransaksi += 1;
            int totalRow = kasir_DGV.Rows.Count;
            string keterangan = "";
            //calculate pengeluaran & pemasukan
            D_ItemDibeli.Clear();


            for(int i = 0; i < totalRow; i++)
            {
                if (kasir_DGV.Rows[i].Cells[5].Value.ToString() == "")
                {
                    D_ItemDibeli.pengeluaran += Int32.Parse(kasir_DGV.Rows[i].Cells[4].Value.ToString());
                    keterangan = "Ada bonus yang diambil";
                }
                else
                {
                    D_ItemDibeli.pemasukan += Int32.Parse(kasir_DGV.Rows[i].Cells[5].Value.ToString());
                    int bonus = Int32.Parse(kasir_DGV.Rows[i].Cells[2].Value.ToString());
                    bonus += Int32.Parse(bonusPelanggan_TB.Text.ToString());
                    Pelanggan.Bonus = "";
                    Pelanggan.Bonus=bonus.ToString();
                }
            }
            //insert data to database

            if (namaPelanggan_TB.Text == "")
            {
                namaPelanggan_TB.Text = "Non-Member";
            }

            SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam, Operator,NamaPelanggan , Kegiatan, Modul, Pemasukan, Pengeluaran, Struk, Keterangan, Bonus) " +
                $"VALUES ( '{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}' , '{Karyawan.Nama}', '{namaPelanggan_TB.Text}' , 'Pelanggan' , 'Kasir' , {D_ItemDibeli.pemasukan} , " +
                $"{D_ItemDibeli.pengeluaran},  '{noStruk_TB.Text}' , '{keterangan}' , {clickedBonus.ToString()})", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                if(!nonMember_CB.Checked && !pelangganBaru_CB.Checked)
                {
                    //Updating bonus into database
                    cmd = new SqlCommand($"UPDATE Pelanggan SET Bonus = '{Pelanggan.Bonus}' WHERE Id_Pelanggan = '{noPelanggan_TB.Text}'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaksi berhasil");
                }
                else if(!nonMember_CB.Checked && pelangganBaru_CB.Checked)
                {
                    // Create new pelanggan db, with bonus =1;
                    cmd = new SqlCommand($"INSERT INTO Pelanggan( Id_Pelanggan , Nama, No_Telp , Alamat, Bonus, Area) " +
                        $"VALUES('{noPelanggan_TB.Text}' , '{namaPelanggan_TB.Text}' , '{noTelepon_TB.Text}' , '{alamatPelanggan_TB.Text}' , {Pelanggan.Bonus},'{areaPelanggan_TB.Text}')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaksi Berhasil");
                }

                else if (nonMember_CB.Checked)
                {
                    //todo
                }
                // adding to barangLog

                int iRow = kasir_DGV.Rows.Count;
                for(int i=0; i < iRow; i++)
                {
                    //MessageBox.Show(i.ToString(), iRow.ToString());
                    cmd = new SqlCommand($"insert into BarangLog(TglWaktu, NamaBarang, Pengurangan, Pemasukan, Struk, totalHarga) " +
                        $"values( '{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}' , '{kasir_DGV.Rows[i].Cells[0].Value.ToString()}', " +
                        $"'{kasir_DGV.Rows[i].Cells[2].Value.ToString()}', 0, '{noStruk_TB.Text}' , " +
                        $" '{kasir_DGV.Rows[i].Cells[5].Value.ToString()}') ", con);

                    SqlCommand cmd2 = new SqlCommand($"update Barang set Jumlah = (select Jumlah from barang where nama = '{kasir_DGV.Rows[i].Cells[0].Value.ToString()}')" +
                            $" -{kasir_DGV.Rows[i].Cells[2].Value.ToString()} where Nama='{kasir_DGV.Rows[i].Cells[0].Value.ToString()}' ", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message + " insert into baranglog failed", "uckasir beli btn error");
                    }
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "beliBTNClick", "UC_KASIR.CS - Beli BTN Click ERROR");
            }
            finally
            {
                con.Close();
            }


            


            #region code sebelum
            //for (int a = 0; a < totalRow; a++)
            //{
            //    if (kasirHelper.totalHarga < 0)
            //    {
            //        kasirHelper.totalHarga = 0;
            //    }
            //    int bonus = 0;
            //    if (kasir_DGV.Rows[a].Cells[5].Value.ToString() == "")
            //    {
            //        bonus += 0;
            //    }
            //    else
            //    {
            //        bonus += Int32.Parse(kasir_DGV.Rows[a].Cells[4].Value.ToString());
            //    }
            //    SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam, Operator,Kegiatan,Modul,Pengeluaran,Pemasukan,Struk)" +
            //        $"VALUES( '{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}', " +
            //        $"'{Karyawan.Nama}','{barang_CB.SelectedItem.ToString()}' , 'Kasir' , {bonus.ToString()}, {kasir_DGV.Rows[a].Cells[5].Value.ToString()}, " +
            //        $"'{noStruk_TB.Text.ToString()}' )", con);
            //    try
            //    {
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        if (nonMember_CB.Checked != true && !pelangganBaru_CB.Checked)
            //        {
            //            if (clickedBonus > 0)
            //            {
            //                Pelanggan.Bonus = (Int32.Parse(Pelanggan.Bonus).ToString());
            //                clickedBonus = 0;
            //            }
            //            else
            //            {
            //                Pelanggan.Bonus = (Int32.Parse(Pelanggan.Bonus) + Int32.Parse(kasir_DGV.Rows[a].Cells[2].Value.ToString())).ToString();
            //            }
            //            cmd = new SqlCommand($"UPDATE Pelanggan SET Bonus = '{Pelanggan.Bonus}' WHERE Id_Pelanggan = '{noPelanggan_TB.Text}'", con);
            //            cmd.ExecuteNonQuery();
            //        }
            //        else if (pelangganBaru_CB.Checked && !nonMember_CB.Checked)
            //        {
            //            Pelanggan.Bonus += Convert.ToInt32(kasir_DGV.Rows[a].Cells[2].Value.ToString());
            //            cmd = new SqlCommand($"INSERT INTO Pelanggan(Id_Pelanggan, Nama, No_Telp, Alamat,Area, Bonus)" +
            //                $"VALUES( '{noPelanggan_TB.Text}','{namaPelanggan_TB.Text}','{noTelepon_TB.Text}','{alamatPelanggan_TB.Text}','{areaPelanggan_TB.Text}','{Pelanggan.Bonus}' )", con);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        pelangganBaru_CB.Enabled = true;
            //        nonMember_CB.Enabled = true;
            //        MessageBox.Show(ex.Message + "\n beliBTN_Click When upload it to database.", "UC_Kasir.cs - beli_BTN_Click Error");
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }

            //    if (kasir_DGV.Rows[a].Cells[5].Value.ToString() != "")
            //    {
            //        kasirHelper.totalHarga += Int32.Parse(kasir_DGV.Rows[a].Cells[5].Value.ToString());
            //    }
            //    else
            //    {
            //        kasirHelper.totalHarga += 0;
            //    }
            //    if (ongkir_TB.Text != "")
            //    {
            //        try
            //        {
            //            kasirHelper.totalHarga += Int32.Parse(ongkir_TB.Text.ToString());
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Pastikan textbox ongkir hanya angka!\nError Message:\n" + ex.Message, "UC_Kasir.cs - beli_Btn_Click ERROR");
            //        }
            //    }
            //}
            #endregion

            kasir_DGV.Rows.Add();
            totalRow = kasir_DGV.Rows.Count - 1;
            for(int a =0; a <= 4; a++)
            {
                kasir_DGV.Rows[totalRow].Cells[a].Value = "";
            }
            // memberikan total harga yang harus dibayar.
            kasir_DGV.Rows[totalRow].Cells[5].Value = D_ItemDibeli.pemasukan.ToString();
            kasirHelper.totalHarga = Int32.Parse(kasir_DGV.Rows[totalRow].Cells[5].Value.ToString());
            #region Menonaktifkan_Button_Yang_Tidak_Terpakai
            //nonaktif
            pelangganBaru_CB.Enabled = false;
            noPelanggan_TB.Enabled = false;
            nonMember_CB.Enabled = false;
            beliLangsung_BTN.Enabled = false;
            namaPelanggan_TB.Enabled = false;
            alamatPelanggan_TB.Enabled = false;
            areaPelanggan_TB.Enabled = false;
            bonusPelanggan_TB.Enabled = false;
            namaPelanggan2_TB.Enabled = false;
            alamatPelanggan2_TB.Enabled = false;
            areaPelanggan2_TB.Enabled = false;
            bonusPelanggan2_TB.Enabled = false;
            ambilBonus_BTN.Enabled = false;
            tambah_BTN.Enabled = false;
            beli_BTN.Enabled = false;
            hapusbarang_BTN.Enabled = false;
            //aktif
            cetakStruk_BTN.Enabled = true;
            baru_BTN.Enabled = true;
            #endregion

            D_ItemDibeli.Clear();

        }

        private void hapusbarang_BTN_Click(object sender, EventArgs e)
        {
            if (kasir_DGV.SelectedRows[0].Cells[0].Value.ToString().Length > 5)
            {
                string cektext = kasir_DGV.SelectedRows[0].Cells[0].Value.ToString().Substring(kasir_DGV.SelectedRows[0].Cells[0].Value.ToString().Length - 5, 5);
                if(cektext == "BONUS")
                {
                    cektext = kasir_DGV.SelectedRows[0].Cells[0].Value.ToString().Substring(0, kasir_DGV.SelectedRows[0].Cells[0].Value.ToString().Length - 6);
                    SqlCommand cmd = new SqlCommand($"select Bonus_Per from Barang where Nama = '{cektext}'",con);
                    try
                    {
                        con.Open();
                        int a = Int32.Parse(bonusPelanggan_TB.Text) + Int32.Parse(cmd.ExecuteScalar().ToString());
                        bonusPelanggan_TB.Text = a.ToString();
                        MessageBox.Show(a.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "hapusBarangbtn-Updating bonus");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            kasir_DGV.Rows.Remove(kasir_DGV.SelectedRows[0]);
        }

        private void kasir_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hapusbarang_BTN.Enabled = true;
        }

        private void cetakStruk_BTN_Click(object sender, EventArgs e)
        {
            if (kasir_DGV.Rows.Count==0)
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("paper", 215, 600);
                printPreviewDialog1.Document = printDocument2;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("paper", 215, 600);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font regular = new Font(FontFamily.GenericSansSerif, 8.0f, FontStyle.Regular);
            Font bold = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Bold);

            e.Graphics.DrawString("NATURAL", bold, Brushes.Black, new Point(35, 0));
            e.Graphics.DrawString("AIR MINUM ISI ULANG", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(60, 30));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new PointF(0f, 43f), new PointF(600f, 43f));
            e.Graphics.DrawString("No Struk :\t" + noStruk_TB.Text.ToString(), regular, Brushes.Black, new Point(5, 45));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), regular, Brushes.Black, new Point(5, 60));

            //draw item
            e.Graphics.DrawString("Barang(pcs)", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(5,75));
            e.Graphics.DrawString("Total Harga", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(120, 75));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, 85f), new PointF(600f, 87f));
            int y = 90;
            int x = 5;
            int totalRow = kasir_DGV.Rows.Count;
            for (int i = 0; i < totalRow; i++)
            {
                if (kasir_DGV.Rows[i].Cells[0].Value.ToString().Length > 10)
                {
                    e.Graphics.DrawString($"{kasir_DGV.Rows[i].Cells[0].Value}({kasir_DGV.Rows[i].Cells[2].Value})", 
                        new Font(FontFamily.GenericSansSerif,5.0f,FontStyle.Regular), Brushes.Black, new Point(x, y + 10));
                }
                else
                {
                    e.Graphics.DrawString($"{kasir_DGV.Rows[i].Cells[0].Value}({kasir_DGV.Rows[i].Cells[2].Value})", regular, Brushes.Black, new Point(x, y + 10));
                }
                e.Graphics.DrawString($"{kasir_DGV.Rows[i].Cells[5].Value}", regular, Brushes.Black, new Point(x + 120, y + 10));
                y += 20;
            }
            e.Graphics.DrawString("Ongkos Kirim : ",regular,Brushes.Black,new Point(x, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString($"{ongkir_TB.Text}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(x, y + (5 * (totalRow - 1) + 30)));
            e.Graphics.DrawString($"{kasirHelper.totalHarga.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 30)));
            y = y + (5 * (totalRow - 1) + 35);
            e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, y + 15));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, y+30f), new PointF(600f, y+32f));

        }

        private void ambilBonus_BTN_Click(object sender, EventArgs e)
        {
            beli_BTN.Enabled = true;
            int pBon = Int32.Parse(bonusPelanggan_TB.Text);
            int bBon = Barang.Bonus_PER;
            if (pBon>=bBon)
            {
                int totalBonus = pBon - bBon;
                Pelanggan.Bonus = totalBonus.ToString();
                bonusPelanggan_TB.Text = totalBonus.ToString();
                kasirHelper.totalHarga -= Barang.Harga_PCS;
                kasir_DGV.Rows.Add();
                int iRow = kasir_DGV.Rows.Count-1;
                kasir_DGV.Rows[iRow].Cells[0].Value = Barang.NamaBarang+" BONUS";
                kasir_DGV.Rows[iRow].Cells[1].Value = "-";
                kasir_DGV.Rows[iRow].Cells[2].Value = "1";
                kasir_DGV.Rows[iRow].Cells[3].Value = Barang.Satuan;
                kasir_DGV.Rows[iRow].Cells[4].Value = "7000";
                kasir_DGV.Rows[iRow].Cells[5].Value = "";
                hapusbarang_BTN.Enabled = true;
                clickedBonus += 1;
            }
        }

        private void gabung_BTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Menggabungkan data pelanggan akan menghapus data pelanggan ke 2 di database\n Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Pelanggan.Bonus = (Convert.ToInt32(Pelanggan.Bonus) + Convert.ToInt32(bonusPelanggan2_TB.Text)).ToString();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Pelanggan WHERE Id_Pelanggan = '{noPelanggan2_TB.Text}'", con);
                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator, Kegiatan, Modul, Target, Nama_Target, Id_Target) " +
                    $"values ('{DateTime.Now.ToString("dd/MM/yyyy")}', '{DateTime.Now.ToString("hh:mm tt")}', '{Karyawan.Nama}', 'Gabung Bonus', 'Kasir','Pelanggan', " +
                    $"'{namaPelanggan2_TB.Text}', '{noPelanggan2_TB.Text}' )", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd = new SqlCommand($"UPDATE Pelanggan " +
                        $"SET Bonus = '{Pelanggan.Bonus}'  WHERE Id_Pelanggan = '{noPelanggan_TB.Text}'  ",con);
                    cmd.ExecuteNonQuery();
                    bonusPelanggan_TB.Text = Pelanggan.Bonus;
                    gabungData_CB.Checked = false;
                    alamatPelanggan2_TB.Enabled = false;
                    namaPelanggan2_TB.Enabled = false;
                    noPelanggan2_TB.Enabled = false;
                    noTelepon2_TB.Enabled = false;
                    bonusPelanggan2_TB.Enabled = false;
                    areaPelanggan2_TB.Enabled = false;
                    //clear
                    alamatPelanggan2_TB.Clear();
                    namaPelanggan2_TB.Clear();
                    noPelanggan2_TB.Clear();
                    noTelepon2_TB.Clear();
                    bonusPelanggan2_TB.Clear();
                    areaPelanggan2_TB.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nGabungBTN Click, When con open and trying to remove or delete db", "UC_KASIR.CS - gabungBTNClick ERROR");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                
            }
        }

        private void gabungData_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (gabungData_CB.Checked)
            {
                noPelanggan2_TB.Enabled = true;
                noTelepon2_TB.Enabled = true;
                noPelanggan2_TB.Focus();
            }
        }

        private void noPelanggan2_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand cmd = new SqlCommand($"SELECT ID FROM Pelanggan WHERE Id_Pelanggan = '{noPelanggan2_TB.Text}'", con);
                try
                {
                    con.Open();
                    if (cmd.ExecuteScalar() != null)
                    {
                        cmd = new SqlCommand($"SELECT Nama, No_Telp, Alamat, Bonus,Area FROM Pelanggan WHERE Id_Pelanggan = '{noPelanggan2_TB.Text}'", con);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            namaPelanggan2_TB.Text = sdr["Nama"].ToString();
                            noTelepon2_TB.Text = sdr["No_Telp"].ToString();
                            alamatPelanggan2_TB.Text = sdr["Alamat"].ToString();
                            bonusPelanggan2_TB.Text = sdr["Bonus"].ToString();
                            areaPelanggan2_TB.Text = sdr["Area"].ToString();
                        }
                        gabung_BTN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Pelanggan Tidak Ditemukan!");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nnoPelanggan2_kEYUP", "UC_KASIR.CS - noPelanggan2TB Error");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void noTelepon2_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && noPelanggan2_TB.Text=="")
            {
                SqlCommand cmd = new SqlCommand($"SELECT ID FROM Pelanggan WHERE No_Telp = '{noTelepon2_TB.Text}'", con);
                try
                {
                    con.Open();
                    if (cmd.ExecuteScalar() != null)
                    {
                        cmd = new SqlCommand($"SELECT Nama, Id_Pelanggan, Alamat, Bonus,Area FROM Pelanggan WHERE No_Telp = '{noTelepon2_TB.Text}' ", con);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            namaPelanggan2_TB.Text = sdr["Nama"].ToString();
                            noPelanggan2_TB.Text = sdr["Id_Pelanggan"].ToString();
                            alamatPelanggan2_TB.Text = sdr["Alamat"].ToString();
                            bonusPelanggan2_TB.Text = sdr["Bonus"].ToString();
                            areaPelanggan2_TB.Text = sdr["Area"].ToString();
                        }
                        gabung_BTN.Enabled= true;
                    }
                    else
                    {
                        MessageBox.Show("Pelanggan Tidak Ditemukan!");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nNoTelp2_KeyUP Error WHEN TRYN TO USING SQL", "UC_KASIR.CS - NOTELP2TBKEYUP");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            //2021110945-1
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT TanggalJam, Operator, BarangLog.NamaBarang as 'Nama_Barang' " +
                $", BarangLog.Pengurangan as 'Jumlah' , BarangLog.totalHarga as 'Total' from TransactionLog " +
                $"inner join BarangLog on TransactionLog.Struk = BarangLog.Struk" +
                $" WHERE TransactionLog.Struk = '{noStruk_TB.Text}' ", con);
            try
            {
                con.Close();
                con.Open();
                string a= "";
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    a = sdr["TanggalJam"].ToString();
                }
                sdr.Close();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                sda.Fill(dt);

                Font regular = new Font(FontFamily.GenericSansSerif, 8.0f, FontStyle.Regular);
                Font bold = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Bold);

                e.Graphics.DrawString("NATURAL", bold, Brushes.Black, new Point(35, 0));
                e.Graphics.DrawString("AIR MINUM ISI ULANG", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(60, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 3), new PointF(0f, 43f), new PointF(600f, 43f));
                e.Graphics.DrawString("No Struk :\t" + noStruk_TB.Text, regular, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("Date : " + a, regular, Brushes.Black, new Point(5, 60));

                e.Graphics.DrawString("Barang(pcs)", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("Total Harga", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(120, 75));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, 85f), new PointF(600f, 87f));

                int totalHarga = 0;
                int x = 5;
                int y = 90;
                dt.Rows[0].ItemArray[0].ToString();

                int dtRIndex = dt.Rows.Count;
                for (int i = 0; i < dtRIndex; i++)
                {
                    e.Graphics.DrawString($"{dt.Rows[i].ItemArray[2].ToString()}", regular, Brushes.Black, new Point(x, y + 10));
                    e.Graphics.DrawString($"{dt.Rows[i].ItemArray[4].ToString()}", regular, Brushes.Black, new Point(x + 120, y + 10));
                    y += 20;
                    totalHarga += Int32.Parse(dt.Rows[i].ItemArray[4].ToString());
                }
                e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(x + 20, y + (5 * (dtRIndex - 1) + 30)));
                e.Graphics.DrawString($"{totalHarga.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (dtRIndex - 1) + 30)));
                y = y + (5 * (dtRIndex - 1) + 35);
                e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, y + 20));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, y + 30f), new PointF(600f, y + 32f));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ucPelanggan - printDoc2");
            }

            finally
            {
                con.Close();
            }
        }

        private void jumlah_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart >=0 )
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}
