using System;

namespace VKSharp.Helpers.DataTypes {
    [Serializable]
    public struct UInt40 :
            IComparable,
            IComparable<Byte>,
            IComparable<UInt16>,
            IComparable<UInt32>,
            IComparable<UInt40>,
            IComparable<UInt64>,
            IComparable<SByte>,
            IComparable<Int16>,
            IComparable<Int32>,
            IComparable<Int64>,

            IEquatable<Byte>,
            IEquatable<UInt16>,
            IEquatable<UInt32>,
            IEquatable<UInt40>,
            IEquatable<UInt64>,
            IEquatable<SByte>,
            IEquatable<Int16>,
            IEquatable<Int32>,
            IEquatable<Int64> {
        public override bool Equals(object obj) {
            if ( ReferenceEquals(null, obj) ) return false;
            return obj is UInt40 && Equals((UInt40) obj);
        }
        public override int GetHashCode() {
            unchecked { return ( this._1.GetHashCode() * 397 ) ^ (int) this._2; }
        }

        private byte _1;
        private uint _2;
        #region Comparers
        public int CompareTo( object obj ) {
            if (!(obj is UInt40))
                throw new ArgumentException();
            var other = (UInt40) obj;
            var cmp = this._1.CompareTo( other._1 );
            return cmp != 0 ? cmp : this._2.CompareTo( other._2 );
        }
        public int CompareTo( UInt40 other ) {
            var cmp = this._1.CompareTo( other._1 );
            return cmp != 0 ? cmp : this._2.CompareTo( other._2 );
        }
        public int CompareTo( byte other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }

        public int CompareTo( ushort other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }
        public int CompareTo( uint other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }
        public int CompareTo( sbyte other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }
        public int CompareTo( short other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }
        public int CompareTo( int other ) {
            return this._1 != 0 ? 1 : this._2.CompareTo( other );
        }
        public int CompareTo( long other ) {
            var cmp = this._1.CompareTo( (byte) ( other >> 32 ) );
            return cmp != 0 ? cmp : this._2.CompareTo( (uint) other );
        }
        public int CompareTo( ulong other ) {
            var cmp = this._1.CompareTo( (byte)(other>>32) );
            return cmp != 0 ? cmp : this._2.CompareTo( (uint)other );
        }
        #endregion
        #region Equality comparers
        public bool Equals( byte other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( ushort other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( uint other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( UInt40 other ) {
            return this._1 == other._1 && this._2 == other._2;
        }
        public bool Equals( sbyte other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( short other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( int other ) {
            return this._1 == 0 && this._2 == other;
        }
        public bool Equals( long other ) {
            return this._1 == (byte) ( other >> 32 ) && this._2 == (uint) other;
        }
        public bool Equals( ulong other ) {
            return this._1 == (byte) ( other >> 32 ) && this._2 == (uint) other;
        }
        #endregion
        #region Some math : UInt40
        public static UInt40 operator +( UInt40 a, UInt40 b ) {
            return (UInt40) ( (ulong) a + (ulong) b );
        }
        public static UInt40 operator -( UInt40 a, UInt40 b ) {
            return (UInt40) ( (ulong) a - (ulong) b );
        }
        public static UInt40 operator *( UInt40 a, UInt40 b ) {
            return (UInt40) ( (ulong) a * (ulong) b );
        }
        public static UInt40 operator /( UInt40 a, UInt40 b ) {
            return (UInt40) ( (ulong) a / (ulong) b );
        }
        public static UInt40 operator >>( UInt40 a, int b ) {
            return (UInt40) ( (ulong) a >> b );
        }
        public static UInt40 operator <<( UInt40 a, int b ) {
            return (UInt40) ( (ulong) a << b );
        }
        #endregion
        #region Some math : UInt32
        public static UInt40 operator +( UInt40 a, UInt32 b ) {
            return (UInt40) ( (ulong) a + b );
        }
        public static UInt40 operator -( UInt40 a, UInt32 b ) {
            return (UInt40) ( (ulong) a - b );
        }
        public static UInt40 operator *( UInt40 a, UInt32 b ) {
            return (UInt40) ( (ulong) a * b );
        }
        public static UInt40 operator /( UInt40 a, UInt32 b ) {
            return (UInt40) ( (ulong) a / b );
        }
        #endregion
        #region Some math : UInt64
        public static UInt40 operator +( UInt40 a, UInt64 b ) {
            return (UInt40) ( (ulong) a + b );
        }
        public static UInt40 operator -( UInt40 a, UInt64 b ) {
            return (UInt40) ( (ulong) a - b );
        }
        public static UInt40 operator *( UInt40 a, UInt64 b ) {
            return (UInt40) ( (ulong) a * b );
        }
        public static UInt40 operator /( UInt40 a, UInt64 b ) {
            return (UInt40) ( (ulong) a / b );
        }
        #endregion
        #region Some math : Int32
        public static UInt40 operator +( UInt40 a, Int32 b ) {
            return (UInt40) ( (long) a + b );
        }
        public static UInt40 operator -( UInt40 a, Int32 b ) {
            return (UInt40) ( (long) a - b );
        }
        public static UInt40 operator *( UInt40 a, Int32 b ) {
            return (UInt40) ( (long) a * b );
        }
        public static UInt40 operator /( UInt40 a, Int32 b ) {
            return (UInt40) ( (long) a / b );
        }
        #endregion
        #region Some math : Int64
        public static UInt40 operator +( UInt40 a, Int64 b ) {
            return (UInt40) ( (long) a + b );
        }
        public static UInt40 operator -( UInt40 a, Int64 b ) {
            return (UInt40) ( (long) a - b );
        }
        public static UInt40 operator *( UInt40 a, Int64 b ) {
            return (UInt40) ( (long) a * b );
        }
        public static UInt40 operator /( UInt40 a, Int64 b ) {
            return (UInt40) ( (long) a / b );
        }
        #endregion

        #region Compare ops : UInt40
        public static bool operator ==( UInt40 a, UInt40 b ) {
            return a._1 == b._1 && a._2 == b._2;
        }
        public static bool operator !=( UInt40 a, UInt40 b ) {
            return a._1 != b._1 || a._2 != b._2;
        }
        public static bool operator >=( UInt40 a, UInt40 b ) {
            return a._1 > b._1 || a._1 == b._1 && a._2 >= b._2;
        }
        public static bool operator <=( UInt40 a, UInt40 b ) {
            return a._1 < b._1 || a._1 == b._1 && a._2 <= b._2;
        }
        public static bool operator <( UInt40 a, UInt40 b ) {
            return a._1 < b._1 || a._1 == b._1 && a._2 < b._2;
        }
        public static bool operator >( UInt40 a, UInt40 b ) {
            return a._1 > b._1 || a._1 == b._1 && a._2 > b._2;
        }
        #endregion
        #region Compare ops : UInt64
        public static bool operator ==( UInt40 a, UInt64 b ) {
            return a._1 == (byte) ( b >> 32 ) && a._2 == (uint) b;
        }
        public static bool operator !=( UInt40 a, UInt64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 != (uint) b;
        }
        public static bool operator >=( UInt40 a, UInt64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 >= (uint) b;
        }
        public static bool operator <=( UInt40 a, UInt64 b ) {
            return a._1 == (byte) ( b >> 32 ) || a._2 <= (uint) b;
        }
        public static bool operator <( UInt40 a, UInt64 b ) {
            return a._1 == (byte) ( b >> 32 ) || a._2 < (uint) b;
        }
        public static bool operator >( UInt40 a, UInt64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 > (uint) b;
        }
        #endregion
        #region Compare ops : Int64
        public static bool operator ==( UInt40 a, Int64 b ) {
            return a._1 == (byte) ( b >> 32 ) && a._2 == (uint) b;
        }
        public static bool operator !=( UInt40 a, Int64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 != (uint) b;
        }
        public static bool operator >=( UInt40 a, Int64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 >= (uint) b;
        }
        public static bool operator <=( UInt40 a, Int64 b ) {
            return a._1 == (byte) ( b >> 32 ) || a._2 <= (uint) b;
        }
        public static bool operator <( UInt40 a, Int64 b ) {
            return a._1 == (byte) ( b >> 32 ) || a._2 < (uint) b;
        }
        public static bool operator >( UInt40 a, Int64 b ) {
            return a._1 != (byte) ( b >> 32 ) || a._2 > (uint) b;
        }
        #endregion
        #region Compare ops : UInt32
        public static bool operator ==( UInt40 a, UInt32 b ) {
            return a._1 == 0 && a._2 == b;
        }
        public static bool operator !=( UInt40 a, UInt32 b ) {
            return a._1 != 0 || a._2 != b;
        }
        public static bool operator >=( UInt40 a, UInt32 b ) {
            return a._1 != 0 || a._2 >= b;
        }
        public static bool operator <=( UInt40 a, UInt32 b ) {
            return a._1 == 0 || a._2 <= b;
        }
        public static bool operator <( UInt40 a, UInt32 b ) {
            return a._1 == 0 || a._2 < b;
        }
        public static bool operator >( UInt40 a, UInt32 b ) {
            return a._1 != 0 || a._2 > b;
        }
        #endregion
        #region Compare ops : Int32
        public static bool operator ==( UInt40 a, Int32 b ) {
            return a._1 == 0 && a._2 == b;
        }
        public static bool operator !=( UInt40 a, Int32 b ) {
            return a._1 != 0 || a._2 != b;
        }
        public static bool operator >=( UInt40 a, Int32 b ) {
            return a._1 != 0 || a._2 >= b;
        }
        public static bool operator <=( UInt40 a, Int32 b ) {
            return a._1 == 0 || a._2 <= b;
        }
        public static bool operator <( UInt40 a, Int32 b ) {
            return a._1 == 0 || a._2 < b;
        }
        public static bool operator >( UInt40 a, Int32 b ) {
            return a._1 != 0 || a._2 > b;
        }
        #endregion
        #region Compare ops : Int16
        public static bool operator ==( UInt40 a, Int16 b ) {
            return a._1 == 0 && a._2 == b;
        }
        public static bool operator !=( UInt40 a, Int16 b ) {
            return a._1 != 0 || a._2 != b;
        }
        public static bool operator >=( UInt40 a, Int16 b ) {
            return a._1 != 0 || a._2 >= b;
        }
        public static bool operator <=( UInt40 a, Int16 b ) {
            return a._1 == 0 || a._2 <= b;
        }
        public static bool operator <( UInt40 a, Int16 b ) {
            return a._1 == 0 || a._2 < b;
        }
        public static bool operator >( UInt40 a, Int16 b ) {
            return a._1 != 0 || a._2 > b;
        }
        #endregion
        #region Compare ops : Int16
        public static bool operator ==( UInt40 a, UInt16 b ) {
            return a._1 == 0 && a._2 == b;
        }
        public static bool operator !=( UInt40 a, UInt16 b ) {
            return a._1 != 0 || a._2 != b;
        }
        public static bool operator >=( UInt40 a, UInt16 b ) {
            return a._1 != 0 || a._2 >= b;
        }
        public static bool operator <=( UInt40 a, UInt16 b ) {
            return a._1 == 0 || a._2 <= b;
        }
        public static bool operator <( UInt40 a, UInt16 b ) {
            return a._1 == 0 || a._2 < b;
        }
        public static bool operator >( UInt40 a, UInt16 b ) {
            return a._1 != 0 || a._2 > b;
        }
        #endregion

        #region Conversions
        public static explicit operator Int64( UInt40 a ) {
            return ( (long) a._1 ) << 32 & a._2;
        }
        public static explicit operator UInt64( UInt40 a ) {
            return ( (ulong) a._1 ) << 32 & a._2;
        }
        public static explicit operator Int32( UInt40 a ) {
            return (int) a._2;
        }
        public static explicit operator UInt32( UInt40 a ) {
            return a._2;
        }
        public static explicit operator Int16( UInt40 a ) {
            return (short) a._2;
        }
        public static explicit operator UInt16( UInt40 a ) {
            return (ushort) a._2;
        }
        public static explicit operator SByte( UInt40 a ) {
            return (sbyte) a._2;
        }
        public static explicit operator Byte( UInt40 a ) {
            return (byte) a._2;
        }

        public static explicit operator UInt40( Int64 a ) {
            return new UInt40 {
                _1 = (byte) ( a >> 32 ),
                _2 = (uint) a
            };
        }
        public static explicit operator UInt40( UInt64 a ) {
            return new UInt40 {
                _1 = (byte) ( a >> 32 ),
                _2 = (uint) a
            };
        }
        public static explicit operator UInt40( Int32 a ) {
            return new UInt40 {
                _1 = 0,
                _2 = (uint) a
            };
        }
        public static explicit operator UInt40( UInt32 a ) {
            return new UInt40 {
                _1 = 0,
                _2 = a
            };
        }
        public static explicit operator UInt40( Int16 a ) {
            return new UInt40 {
                _1 = 0,
                _2 = (uint) a
            };
        }
        public static explicit operator UInt40( UInt16 a ) {
            return new UInt40 {
                _1 = 0,
                _2 = a
            };
        }
        public static explicit operator UInt40( SByte a ) {
            return new UInt40 {
                _1 = 0,
                _2 = (uint) a
            };
        }
        public static explicit operator UInt40( Byte a ) {
            return new UInt40 {
                _1 = 0,
                _2 = a
            };
        }
        public override string ToString() {
            return ( (ulong) this ).ToString( BuiltInData.Instance.NC );
        }
        public static UInt40 Parse(string s) {
            return (UInt40) ulong.Parse(s);
        }
        #endregion
    }
}