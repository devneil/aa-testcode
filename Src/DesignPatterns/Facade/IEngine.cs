namespace DesignPatterns.Facade
{
    interface IEngine
    {
        void StartEngine();
        void StopEngine();
        decimal GetTemperature();
        decimal GetAge();
        void Accelerate();
    }
}