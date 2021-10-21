class AbstractTransport
    {
        public virtual int Fuel { get; set; }
        public virtual int Mileage { get; set; }
        public virtual int Price { get; set; }
    }
    
    class Airplane : FlyingTransport
    {
        public string planeType;
        public byte passengerCapacity;

        public void LandTo()
        {

        }
    }
    
    sealed class BattleAirplane : Airplane
    {
        public int BombAmmo { get; set; }

        public void Attack()
        {

        }
    }
    
    class BattleHelicopter : Helicopter
    {
        private Type type;
        public int MinigunPower;

        public BattleHelicopter(Type type)
        {
            this.type = type;
        }

        public virtual void Attack()
        {

        }
    }
    
    class FlyingTransport : AbstractTransport
    {
        public string Type;

        public void ShowAllTypes()
        {

        }
    }
    
    class Mi_6 : BattleHelicopter
    {
        public int MinigunAmmo { get; set; }
        
        public void MinigunAttack()
        {

        }

        public override void Attack()
        {

        }
    }
