using DesafioPOO.Models;

Nokia n = new Nokia("998312582", "3120", "136548745654", 32);
Iphone i = new Iphone("992427161", "11", "545465481488", 128);

n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("App Teste");

i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("App Teste");