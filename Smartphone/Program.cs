//Fazendo uma ligação peli IPHONE.
using Smartphone.Models;

Nokia nokia = new Nokia();
Iphone iphone = new Iphone();
iphone.Ligar("11979856633");
iphone.RecebendoLigacao("21961610531");
iphone.ApresentarModelo();
iphone.InstalarAplicativo("Telegram");

nokia.Ligar("21965463212");
nokia.RecebendoLigacao("21912364878");
nokia.ApresentarModelo();
nokia.InstalarAplicativo("WhatsApp");