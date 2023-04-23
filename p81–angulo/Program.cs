string TipoAngulo(int angulo){
    if (angulo < 90)
    {
        return "agudo";
    }else if(angulo == 90){
        return "recto";
    }else if(angulo > 90 && angulo < 180){
        return "obtuso";
    }else if(angulo == 180 ){
        return "llano";
    }else if(angulo > 180 && angulo < 360 ){
        return "concavo";
    }else{
        return "invalido";
    }
}

System.Console.WriteLine("Ingrese un angulo entre 0 y 360 grados: ");
int angulo = int.Parse(Console.ReadLine());

string tipoAngulo = TipoAngulo(angulo);

Console.WriteLine($"el angulo {angulo} es {tipoAngulo}");
