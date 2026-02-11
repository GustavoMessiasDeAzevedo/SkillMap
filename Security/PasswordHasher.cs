using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace SkillMap.Security
{
    public static class PasswordHasher
    {
        public static (string Hash, string Salt) CriarHash(string senha)
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);
            string salt = Convert.ToBase64String(saltBytes);

            string hash = Convert.ToBase64String(

                KeyDerivation.Pbkdf2(

                    password:senha,
                    salt:saltBytes,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000,
                    numBytesRequested: 32

                    )

                );

            return (hash, salt);
        }


        public static bool VerficarSenha(string senhaDigitada, string hashSalvo, string saltoSalvo)
        {
            byte[] saltBytes = Convert.FromBase64String(saltoSalvo);

            string hashDigitado = Convert.ToBase64String(

                KeyDerivation.Pbkdf2(

                    password: senhaDigitada,
                    salt: saltBytes,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000,
                    numBytesRequested: 32

                    )
                );

            return hashDigitado == hashSalvo;
        }
    }
}
