﻿namespace Phnx.Random.Generator
{
    /// <summary>
    /// Provides methods for generating a random <see cref="char"/> from only letters of the alphabet
    /// </summary>
    public static class RandomLetterGenerator
    {
        /// <summary>
        /// The uppercase alphabet in a <see cref="T:char[]"/>
        /// </summary>
        public static readonly char[] UpperCaseAlphabet = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z'
        };

        /// <summary>
        /// The lowercase alphabet in a <see cref="T:char[]"/>
        /// </summary>
        public static readonly char[] LowerCaseAlphabet = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z'
        };

        /// <summary>
        /// Get a random upper or lower case letter of the alphabet
        /// </summary>
        /// <returns>A random upper or lower case letter of the alphabet</returns>
        public static char Get()
        {
            if (GetRandom.Bool())
            {
                // Get upper case
                return GetUpperCase();
            }
            else
            {
                // Get lower case
                return GetLowerCase();
            }
        }

        /// <summary>
        /// Get a random upper case letter of the alphabet
        /// </summary>
        /// <returns>A random upper case letter of the alphabet</returns>
        public static char GetUpperCase()
        {
            return GetRandom.OneOf(UpperCaseAlphabet);
        }


        /// <summary>
        /// Get a random lower case letter of the alphabet
        /// </summary>
        /// <returns>A random lower case letter of the alphabet</returns>
        public static char GetLowerCase()
        {
            return GetRandom.OneOf(LowerCaseAlphabet);
        }
    }
}
