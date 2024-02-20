namespace Core.Entities
{
    public class User : Entity<int>
    {
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Approved { get; set; }

        // abc123 => PlainText
        //abc12123 + SALT => HASH
        //Hashing SHA512, MD5 =>5RTRYTGFSDSFGHJUYTGFC
        //düz bir metinin farklı karakterlerle hashlenerek tutulması, şifreyi direkt göremiyoruz..
        //salting : şifrenin güvenliğini arttıran 2. mekanizma. aynı parolaların farklı hash değerleri ile tutarak güvenliği arttırır. 
    }
}
