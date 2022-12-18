

 
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
 
namespace System.Numerics
{
    
    
    
    public partial struct Vector2 : IEquatable<Vector2>, IFormattable
    {
        #region Public Static Properties
        
        
        
        public static Vector2 Zero { get { return new Vector2(); } }
        
        
        
        public static Vector2 One { get { return new Vector2(1.0f, 1.0f); } }
        
        
        
        public static Vector2 UnitX { get { return new Vector2(1.0f, 0.0f); } }
        
        
        
        public static Vector2 UnitY { get { return new Vector2(0.0f, 1.0f); } }
        #endregion Public Static Properties
 
        #region Public instance methods
        
        
        
        
        public override int GetHashCode()
        {
            int hash = this.X.GetHashCode();
            hash = HashCodeHelper.CombineHashCodes(hash, this.Y.GetHashCode());
            return hash;
        }
 
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (!(obj is Vector2))
                return false;
            return Equals((Vector2)obj);
        }
 
        
        
        
        
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }
 
        
        
        
        
        
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }
 
        
        
        
        
        
        
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            StringBuilder sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(this.X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(this.Y.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }
 
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Length()
        {
            if (Vector.IsHardwareAccelerated)
            {
                float ls = Vector2.Dot(this, this);
                return (float)Math.Sqrt(ls);
            }
            else
            {
                float ls = X * X + Y * Y;
                return (float)Math.Sqrt((double)ls);
            }
        }
 
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float LengthSquared()
        {
            if (Vector.IsHardwareAccelerated)
            {
                return Vector2.Dot(this, this);
            }
            else
            {
                return X * X + Y * Y;
            }
        }
        #endregion Public Instance Methods
 
        #region Public Static Methods
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector2 value1, Vector2 value2)
        {
            if (Vector.IsHardwareAccelerated)
            {
                Vector2 difference = value1 - value2;
                float ls = Vector2.Dot(difference, difference);
                return (float)System.Math.Sqrt(ls);
            }
            else
            {
                float dx = value1.X - value2.X;
                float dy = value1.Y - value2.Y;
 
                float ls = dx * dx + dy * dy;
 
                return (float)Math.Sqrt((double)ls);
            }
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceSquared(Vector2 value1, Vector2 value2)
        {
            if (Vector.IsHardwareAccelerated)
            {
                Vector2 difference = value1 - value2;
                return Vector2.Dot(difference, difference);
            }
            else
            {
                float dx = value1.X - value2.X;
                float dy = value1.Y - value2.Y;
 
                return dx * dx + dy * dy;
            }
        }
 
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Normalize(Vector2 value)
        {
            if (Vector.IsHardwareAccelerated)
            {
                float length = value.Length();
                return value / length;
            }
            else
            {
                float ls = value.X * value.X + value.Y * value.Y;
                float invNorm = 1.0f / (float)Math.Sqrt((double)ls);
 
                return new Vector2(
                    value.X * invNorm,
                    value.Y * invNorm);
            }
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Reflect(Vector2 vector, Vector2 normal)
        {
            if (Vector.IsHardwareAccelerated)
            {
                float dot = Vector2.Dot(vector, normal);
                return vector - (2 * dot * normal);
            }
            else
            {
                float dot = vector.X * normal.X + vector.Y * normal.Y;
 
                return new Vector2(
                    vector.X - 2.0f * dot * normal.X,
                    vector.Y - 2.0f * dot * normal.Y);
            }
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
        {
            
            
            float x = value1.X;
            x = (x > max.X) ? max.X : x;
            x = (x < min.X) ? min.X : x;
 
            float y = value1.Y;
            y = (y > max.Y) ? max.Y : y;
            y = (y < min.Y) ? min.Y : y;
 
            return new Vector2(x, y);
        }
 
        
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
        {
            return new Vector2(
                value1.X + (value2.X - value1.X) * amount,
                value1.Y + (value2.Y - value1.Y) * amount);
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Transform(Vector2 position, Matrix3x2 matrix)
        {
            return new Vector2(
                position.X * matrix.M11 + position.Y * matrix.M21 + matrix.M31,
                position.X * matrix.M12 + position.Y * matrix.M22 + matrix.M32);
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Transform(Vector2 position, Matrix4x4 matrix)
        {
            return new Vector2(
                position.X * matrix.M11 + position.Y * matrix.M21 + matrix.M41,
                position.X * matrix.M12 + position.Y * matrix.M22 + matrix.M42);
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 TransformNormal(Vector2 normal, Matrix3x2 matrix)
        {
            return new Vector2(
                normal.X * matrix.M11 + normal.Y * matrix.M21,
                normal.X * matrix.M12 + normal.Y * matrix.M22);
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 TransformNormal(Vector2 normal, Matrix4x4 matrix)
        {
            return new Vector2(
                normal.X * matrix.M11 + normal.Y * matrix.M21,
                normal.X * matrix.M12 + normal.Y * matrix.M22);
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Transform(Vector2 value, Quaternion rotation)
        {
            float x2 = rotation.X + rotation.X;
            float y2 = rotation.Y + rotation.Y;
            float z2 = rotation.Z + rotation.Z;
 
            float wz2 = rotation.W * z2;
            float xx2 = rotation.X * x2;
            float xy2 = rotation.X * y2;
            float yy2 = rotation.Y * y2;
            float zz2 = rotation.Z * z2;
 
            return new Vector2(
                value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2),
                value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2));
        }
        #endregion Public Static Methods
 
        #region Public operator methods
        
        
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 left, Vector2 right)
        {
            return left + right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(Vector2 left, Vector2 right)
        {
            return left - right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2 left, Vector2 right)
        {
            return left * right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2 left, Single right)
        {
            return left * right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Single left, Vector2 right)
        {
            return left * right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2 left, Vector2 right)
        {
            return left / right;
        }
 
        
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2 left, Single divisor)
        {
            return left / divisor;
        }
 
        
        
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Negate(Vector2 value)
        {
            return -value;
        }
        #endregion Public operator methods
    }
}