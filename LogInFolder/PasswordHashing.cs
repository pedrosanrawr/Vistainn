using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHashing
{
    public static(string hashedPassword, string salt) HashPassword(string password)
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000)) 
            {
                byte[] hashBytes = pbkdf2.GetBytes(32); 
                string hash = Convert.ToBase64String(hashBytes);

                return (hash, salt);
            }
        }
    }

    public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
    {
        byte[] saltBytes = Convert.FromBase64String(storedSalt);

        using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000))
        {
            byte[] hashBytes = pbkdf2.GetBytes(32); 
            string hash = Convert.ToBase64String(hashBytes);

            return hash == storedHash;
        }
    }
}