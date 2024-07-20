//percabangan
Console.WriteLine("Selamat datang, silahkan masukkan umur anda");
int umur = Convert.ToInt32(Console.ReadLine());
int harga;

if (umur < 18)
{
    Console.WriteLine("Mohon maaf umur anda kurang!");
}
else if (umur >= 18)
{
    Console.WriteLine("VVIP");
    Console.WriteLine("VIP");
    Console.WriteLine("Reguler");
    Console.WriteLine("Silahkan pilih ticket anda");
    string ticket = Console.ReadLine();
    double kembalian;
    switch (ticket)
    {
        case "VVIP":
            harga = 200000;
            Console.WriteLine("VVIP");
            Console.WriteLine("harga ticket :" + harga);
            Console.WriteLine("Masukkan uang anda");
            int bayar = Convert.ToInt32(Console.ReadLine());
            if (bayar < harga)
            {
                Console.WriteLine("Maaf uang anda kurang cukup");
            }
            else if (bayar >= harga)
            {
                kembalian = bayar - harga;
                Console.WriteLine(kembalian);
            }
            break;
        case "VIP":
            harga = 150000;
            Console.WriteLine("VVIP");
            Console.WriteLine("harga ticket :" + harga);
            Console.WriteLine("Masukkan uang anda");
            int bayar2 = Convert.ToInt32(Console.ReadLine());
            if (bayar2 < harga)
            {
                Console.WriteLine("Maaf uang anda kurang cukup");
            }
            else if (bayar2 >= harga)
            {
                kembalian = bayar2 - harga;
                Console.WriteLine(kembalian);
            }
            break;
        case "Reguler":
            harga = 100000;
            Console.WriteLine("VVIP");
            Console.WriteLine("harga ticket :" + harga);
            Console.WriteLine("Masukkan uang anda");
            int bayar3 = Convert.ToInt32(Console.ReadLine());
            if (bayar3 < harga)
            {
                Console.WriteLine("Maaf uang anda kurang cukup");
            }
            else if (bayar3 >= harga)
            {
                kembalian = bayar3 - harga;
                Console.WriteLine(kembalian);
            }
            break;
        default:
            break;
    }
}
//Looping

for(int x = 0; x < 10; x++)
{
    Console.WriteLine(x);
}

int[] y = {1 , 2, 3};
foreach(int a in y)
{
    Console.Write(a);
}
