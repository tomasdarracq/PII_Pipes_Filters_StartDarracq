using System;
using CompAndDel;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio 123
           /*
            //IMAGEN
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            //FILTROS
            FilterGreyscale filterGrey = new FilterGreyscale();
            FilterNegative filterNegative = new FilterNegative();
            //PIPES
            PipeNull pipeNull = new PipeNull();
            PipeSerial Pipe2 = new PipeSerial(new FilterBlurConvolution(), pipeNull);
            PipeSerial initialPipe = new PipeSerial(filterGrey,Pipe2);
            //CARGA IMAGEN con el path para subir en Twitter
            provider.SavePicture(initialPipe.Send(picture,@"luke2.jpg" ), @"luke2.jpg");
            */
        //ejercicio 4 sin termianr
           PipeNull pipenull = new PipeNull();
           FilterNegative filterNegative = new FilterNegative();
           FilterGreyscale filterGrey = new FilterGreyscale();

           PipeSerial pipe3 = new PipeSerial(filterGrey, pipenull);
           PipeSerial pipe4 = new PipeSerial(filterNegative, pipenull);
           PipeFork pipeFork = new PipeFork(pipe3,pipe4);
        }
    }
}
