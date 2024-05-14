namespace CarFactoryLibrary
{
    public abstract class Car
    {
        public double velocity { get; set; }
        public DrivingMode drivingMode { get; set; }

        public Car()
        {
            velocity = 0;
            drivingMode = DrivingMode.Stopped;
        }
        public Boolean IsStopped()
        {
            return velocity == 0 ? true : false;
        }
        public Boolean IsMoving()
        {
            return velocity != 0 ? true : false;
        }
        public void Stop()
        {
            velocity = 0;
            drivingMode = DrivingMode.Stopped;
        }

        public void IncreaseVelocity(double addedVelocity,DrivingMode DrivingMode=DrivingMode.Forward)
        {
            velocity += addedVelocity;
            drivingMode = DrivingMode;
        }
        public void DecreaseVelocity(double DecreasedVelocity, DrivingMode DrivingMode = DrivingMode.Forward)
        {
            velocity -= DecreasedVelocity;
            drivingMode = DrivingMode;
        }

        public abstract void Accelerate();
        public abstract void Deccelerate();


        public string GetDirection()
        {
            return drivingMode.ToString();
        }

        public Car GetMyCar()
        {
            return this;
        }


        public double TimeToCoverDistance(double distance)
        {
            return distance / velocity;
        }

        public override bool Equals(object? obj)
        {
            Car? car = obj as Car;
            if (car == null) return false;

            return car.velocity == velocity && car.drivingMode == drivingMode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.drivingMode, this.velocity);
        }
    }
}