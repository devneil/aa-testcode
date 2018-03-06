namespace DesignPatterns.Facade
{
    interface IIndicators
    {
        void LeftTurnOn();
        void LeftTurnOff();
        void RightTurnOn();
        void RightTurnOff();
        void HazardsOn();
        void HazardsOff();
    }
}