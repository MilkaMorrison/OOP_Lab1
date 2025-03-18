using lab1_2;

AmericanTimePrinter a = new AmericanTimePrinter();
EuropeTimePrinter e = new EuropeTimePrinter();
a.PrintTime();
e.PrintTime();

ConcreteDecorator cd1 = new ConcreteDecorator(a, "+++");
ConcreteDecorator cd2 = new ConcreteDecorator(e, "---");
cd1.PrintTime();
cd2.PrintTime();
