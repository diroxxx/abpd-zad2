using ConsoleApp1.Containers;

ContainerShip containerShip = new ContainerShip(500, 10, 2);
GasContainer gasContainer1 = new GasContainer(300.0, 500, 800, 300, 600, 200);

gasContainer1.load(100);
containerShip.addContainer(gasContainer1);

LiquidContainer liquidContainer1 = new LiquidContainer(100, 300, 500, 200, 600, true);
RefrigerationContainer refrigerationContainer =
    new RefrigerationContainer(400, 450, 200, 100, 1000, "Bananas", 13.3, 13.3);

List<Container> containers = new List<Container>();
containers.Add(liquidContainer1);
containers.Add(refrigerationContainer);

containerShip.addContainers(containers);

// containerShip.removeContainer(gasContainer1);
// containerShip.unloadConteinerShip();

containerShip.changeContainer("KON-C-2", new GasContainer(100, 300,300,200,700,500));

containerShip.infoAboutContainer(gasContainer1);

// containerShip.infoAboutContainerShip();


