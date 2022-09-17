using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEEK
{
    public static class DatabaseLayer
    {
        public static string connectionString = @"Server=LAPTOP-523AQ309;Database=SWEEK;Trusted_Connection=True;";

        public static int GirisYap(string kullaniciAdi, string sifre, string isim, string soyisim)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM KULLANICI WHERE Username=@Username AND Sifre=@Sifre AND Kname=@Kname AND Surname=@Surname";
                komut.Parameters.AddWithValue("@Username", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);
                komut.Parameters.AddWithValue("@Kname", isim);
                komut.Parameters.AddWithValue("@Surname", soyisim);
                komut.Connection = baglanti;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DataTable GetirHikayeler()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT s.HikayeId 'Hikaye Numarası', s.Sname 'Hikayenin Adı', s.Bolum_sayisi 'Bölüm Sayısı', s.Dil 'Dili', s.Ozet 'Hikayenin Tanıtımı', s.Writer_name 'Yazarının Adı ve Soyadı', s.Icerik 'Hikayenin Kendisi' FROM STORYY s";
                komut.Connection = baglanti;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable GetirHikaye_ismi()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT s.Sname FROM STORYY s";
                komut.Connection = baglanti;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable GetirYazar_ismi()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT s.Writer_name FROM STORYY s";
                komut.Connection = baglanti;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int EkleYeniHikaye(string name, string bolum_sayisi, string dil, string ozet, string writer_name, string icerik)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO STORYY(Sname,Bolum_sayisi,Dil,Ozet,Writer_name,Icerik) VALUES(@Sname,@Bolum_sayisi,@Dil,@Ozet,@Writer_name,@Icerik)";

                komut.Parameters.AddWithValue("@Sname", name);
                komut.Parameters.AddWithValue("@Bolum_sayisi", bolum_sayisi);
                komut.Parameters.AddWithValue("@Dil", dil);
                komut.Parameters.AddWithValue("@Ozet", ozet);
                komut.Parameters.AddWithValue("@Writer_name", writer_name);
                komut.Parameters.AddWithValue("@Icerik", icerik);
                komut.Connection = baglanti;
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                return 1;
            }
            catch (Exception)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                return 0;
            }
        }

        public static int GuncelleHikaye(string hikayeAdi, string bolumSayisi, string dili, string ozeti, string kendisi, string yazaradsoyad)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "UPDATE STORYY SET Bolum_sayisi=@Bolum_sayisi, Dil=@Dil, Ozet=@Ozet, Icerik=@Icerik, Writer_name=@Writer_name WHERE Sname=@Sname";  
                komut.Parameters.AddWithValue("@Bolum_sayisi", bolumSayisi);
                komut.Parameters.AddWithValue("@Dil", dili);
                komut.Parameters.AddWithValue("@Ozet", ozeti);
                komut.Parameters.AddWithValue("@Icerik", kendisi);
                komut.Parameters.AddWithValue("@Sname", hikayeAdi);
                komut.Parameters.AddWithValue("@Writer_name", yazaradsoyad);
                komut.Connection = baglanti;
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                return 1;
            }
            catch (Exception)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                return 0;
            }
        }

        public static int SilHikaye(string hikayeismi)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "DELETE FROM STORYY WHERE Sname=@Sname";
                komut.Parameters.AddWithValue("@Sname", hikayeismi);
                komut.Connection = baglanti;
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                return 1;
            }
            catch (Exception)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                return 0;
            }
        }
    }
}
