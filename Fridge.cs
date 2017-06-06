namespace FridgeConsole
{
    public class Fridge
    {
        private bool state;
        private FridgeMode mode;
        private byte temp;

        public Fridge(bool state, FridgeMode mode, byte temp)
        {
            this.state = state;
            this.mode = mode;
            this.temp = temp;
        }

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        public void SetNormMode()
        {
            mode = FridgeMode.Norm;
            temp = 5;
        }

        public void SetVacationMode()
        {
            mode = FridgeMode.Vacation;
            temp = 9;
        }

        public void SetSuperFrozeMode()
        {
            mode = FridgeMode.SuperFroz;
            temp = 1;
        }

        public void UpTemp()						
        {
            mode = FridgeMode.HandManagment;
            if (temp >= 9)
            { temp = 9; }               		

            else
            { temp++; }
        }

        public void DownTemp()
        {
            mode = FridgeMode.HandManagment;
            if (temp <= 1)
            { temp = 1; }
            else
            { temp --; }
        }

        public string Info()
        {
            string state;
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }

            string mode;
            if (this.mode == FridgeMode.Norm)
            {
                mode = "оптимальный";
            }
            else if (this.mode == FridgeMode.Vacation)
            {
                mode = "отпуск";
            }
            else if (this.mode == FridgeMode.HandManagment)
            {
                mode = "ручное управление";
            }
            else
            {
                mode = "супер заморозки";
            }

            return "Состояние: " + state + ", режим: " + mode+", температура: " + temp;
        }
    }
}
