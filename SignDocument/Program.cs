using System;

namespace SignDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            Document.AddText();
        }
    }
    class Document
    {
        public string Name;

        public static void AddText()
        {
            SignedDocument myMark = new SignedDocument();

            Console.WriteLine("Please Sign your name: ");
            myMark.Signature = Console.ReadLine();
            Console.WriteLine("Signature: " + myMark.Signature);

            //testing for second entry of signature
            Console.WriteLine("Try signing again: ");
            myMark.Signature = Console.ReadLine();

        }
    }

    class SignedDocument : Document
    {
        private string signature;
        public string Signature
        {
            get { return signature; }
            set
            {   //if signature is not null, we know that it already has value i.e. can only be set once
                if (signature != null)
                {
                    throw new ArgumentException();

                }
                this.signature = value;
            }

        }
    }
}
