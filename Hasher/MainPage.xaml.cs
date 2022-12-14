using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace Hasher;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void MD5Hash(object sender, EventArgs e)
    {
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(Eingabe.Text));
            Eingabe.Text = BitConverter.ToString(bytes).Replace("-", "").ToUpper().ToString();
        }
    }

    private void SHA256Hash(object sender, EventArgs e)
    {
        using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
        {
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Eingabe.Text));
            Eingabe.Text = BitConverter.ToString(bytes).Replace("-", "").ToLower().ToString();
        }
    }

    private void SHA384Hash(object sender, EventArgs e)
    {
        using (System.Security.Cryptography.SHA384 sha384 = System.Security.Cryptography.SHA384.Create())
        {
            var bytes = sha384.ComputeHash(Encoding.UTF8.GetBytes(Eingabe.Text));
            Eingabe.Text = BitConverter.ToString(bytes).Replace("-", "").ToLower().ToString();
        }
    }

    private void SHA512Hash(object sender, EventArgs e)
    {
        using (System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create())
        {
            var bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(Eingabe.Text));
            Eingabe.Text = BitConverter.ToString(bytes).Replace("-", "").ToLower().ToString();
        }
    }
}

