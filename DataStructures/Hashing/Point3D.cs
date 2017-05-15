using System;

namespace DataStructures.Hashing
{
    /// <summary>
    /// Class representing a point in three dimensional space.
    /// </summary>
    public class Point3D
    {
        public double X;
        public double Y;
        public double Z;
        /// <summary>
        /// Constructs a new <see cref="Point3D"/> instance
        /// with the specified Cartesian coordinates of the point.
        /// </summary>
        /// <param name="x">x coordinate of the point</param>
        /// <param name="y">y coordinate of the point</param>
        /// <param name="z">z coordinate of the point</param>
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            Point3D other = obj as Point3D;
            if (other == null)
                return false;
            if (!this.X.Equals(other.X))
                return false;
            if (!this.Y.Equals(other.Y))
                return false;
            if (!this.Z.Equals(other.Z))
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            //int prime = 83;
            //int result = 1;
            //unchecked
            //{
            //    result = result * prime + X.GetHashCode();
            //    result = result * prime + Y.GetHashCode();
            //    result = result * prime + Z.GetHashCode();
            //}

            int result = (int)Math.Round((X + Y + Z));
            return result;
        }
        public override string ToString()
        {
            return string.Format("X={0} Y={1} Z={2}", X, Y, Z);
        }
    }
}