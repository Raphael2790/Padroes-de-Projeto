namespace Design_patterns.AbstractFactory
{
    //Uma fabrica abstrata sempre cria instancias de duas ou mais classes relacionadas
    //Ou seja toda vez que criarmos um veiculo temos que criar um guincho para o atendimento do mesmo
    public abstract class VehicleRescueFactory
    {
        public abstract Vehicle CreateVehicle(string modelName, Size size);
        public abstract Wrecker CreateWrecker();
    }
}
