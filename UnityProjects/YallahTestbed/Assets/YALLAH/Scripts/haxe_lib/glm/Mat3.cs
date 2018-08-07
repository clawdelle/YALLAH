// Generated by Haxe 3.4.2
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace glm {
	public class Mat3 : global::haxe.lang.HxObject {
		
		public Mat3(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Mat3(global::haxe.lang.Null<double> _r0c0, global::haxe.lang.Null<double> _r0c1, global::haxe.lang.Null<double> _r0c2, global::haxe.lang.Null<double> _r1c0, global::haxe.lang.Null<double> _r1c1, global::haxe.lang.Null<double> _r1c2, global::haxe.lang.Null<double> _r2c0, global::haxe.lang.Null<double> _r2c1, global::haxe.lang.Null<double> _r2c2) {
			global::glm.Mat3.__hx_ctor_glm_Mat3(this, _r0c0, _r0c1, _r0c2, _r1c0, _r1c1, _r1c2, _r2c0, _r2c1, _r2c2);
		}
		
		
		public static void __hx_ctor_glm_Mat3(global::glm.Mat3 __hx_this, global::haxe.lang.Null<double> _r0c0, global::haxe.lang.Null<double> _r0c1, global::haxe.lang.Null<double> _r0c2, global::haxe.lang.Null<double> _r1c0, global::haxe.lang.Null<double> _r1c1, global::haxe.lang.Null<double> _r1c2, global::haxe.lang.Null<double> _r2c0, global::haxe.lang.Null<double> _r2c1, global::haxe.lang.Null<double> _r2c2) {
			double __temp__r2c228 = ( ( ! (_r2c2.hasValue) ) ? (((double) (0) )) : ((_r2c2).@value) );
			double __temp__r2c127 = ( ( ! (_r2c1.hasValue) ) ? (((double) (0) )) : ((_r2c1).@value) );
			double __temp__r2c026 = ( ( ! (_r2c0.hasValue) ) ? (((double) (0) )) : ((_r2c0).@value) );
			double __temp__r1c225 = ( ( ! (_r1c2.hasValue) ) ? (((double) (0) )) : ((_r1c2).@value) );
			double __temp__r1c124 = ( ( ! (_r1c1.hasValue) ) ? (((double) (0) )) : ((_r1c1).@value) );
			double __temp__r1c023 = ( ( ! (_r1c0.hasValue) ) ? (((double) (0) )) : ((_r1c0).@value) );
			double __temp__r0c222 = ( ( ! (_r0c2.hasValue) ) ? (((double) (0) )) : ((_r0c2).@value) );
			double __temp__r0c121 = ( ( ! (_r0c1.hasValue) ) ? (((double) (0) )) : ((_r0c1).@value) );
			double __temp__r0c020 = ( ( ! (_r0c0.hasValue) ) ? (((double) (0) )) : ((_r0c0).@value) );
			__hx_this._00 = __temp__r0c020;
			__hx_this._01 = __temp__r1c023;
			__hx_this._02 = __temp__r2c026;
			__hx_this._10 = __temp__r0c121;
			__hx_this._11 = __temp__r1c124;
			__hx_this._12 = __temp__r2c127;
			__hx_this._20 = __temp__r0c222;
			__hx_this._21 = __temp__r1c225;
			__hx_this._22 = __temp__r2c228;
		}
		
		
		public static global::glm.Mat3 identity(global::glm.Mat3 dest) {
			unchecked {
				dest._00 = ((double) (1) );
				dest._10 = ((double) (0) );
				dest._20 = ((double) (0) );
				dest._01 = ((double) (0) );
				dest._11 = ((double) (1) );
				dest._21 = ((double) (0) );
				dest._02 = ((double) (0) );
				dest._12 = ((double) (0) );
				dest._22 = ((double) (1) );
				return dest;
			}
		}
		
		
		public static global::glm.Mat3 copy(global::glm.Mat3 src, global::glm.Mat3 dest) {
			dest._00 = src._00;
			dest._10 = src._10;
			dest._20 = src._20;
			dest._01 = src._01;
			dest._11 = src._11;
			dest._21 = src._21;
			dest._02 = src._02;
			dest._12 = src._12;
			dest._22 = src._22;
			return dest;
		}
		
		
		public static global::glm.Mat3 transpose(global::glm.Mat3 src, global::glm.Mat3 dest) {
			double src_r1c0 = src._01;
			double src_r2c0 = src._02;
			double src_r2c1 = src._12;
			dest._00 = src._00;
			dest._01 = src._10;
			dest._02 = src._20;
			dest._10 = src_r1c0;
			dest._11 = src._11;
			dest._12 = src._21;
			dest._20 = src_r2c0;
			dest._21 = src_r2c1;
			dest._22 = src._22;
			return dest;
		}
		
		
		public static double cofactor(double a, double b, double c, double d) {
			return ( ( a * d ) - ( b * c ) );
		}
		
		
		public static double determinant(global::glm.Mat3 src) {
			double c00 = ( ( src._11 * src._22 ) - ( src._21 * src._12 ) );
			double c01 = ( ( src._10 * src._22 ) - ( src._20 * src._12 ) );
			double c02 = ( ( src._10 * src._21 ) - ( src._20 * src._11 ) );
			return ( ( ( src._00 * c00 ) - ( src._01 * c01 ) ) + ( src._02 * c02 ) );
		}
		
		
		public static global::glm.Mat3 invert(global::glm.Mat3 src, global::glm.Mat3 dest) {
			double c00 = ( ( src._11 * src._22 ) - ( src._21 * src._12 ) );
			double c01 = ( ( src._10 * src._22 ) - ( src._20 * src._12 ) );
			double c02 = ( ( src._10 * src._21 ) - ( src._20 * src._11 ) );
			double det = ( ( ( src._00 * c00 ) - ( src._01 * c01 ) ) + ( src._02 * c02 ) );
			if (( global::System.Math.Abs(((double) (det) )) < global::glm.GLM.EPSILON )) {
				throw global::haxe.lang.HaxeException.wrap("determinant is too small");
			}
			
			double c10 = ( ( src._01 * src._22 ) - ( src._21 * src._02 ) );
			double c11 = ( ( src._00 * src._22 ) - ( src._20 * src._02 ) );
			double c12 = ( ( src._00 * src._21 ) - ( src._20 * src._01 ) );
			double c20 = ( ( src._01 * src._12 ) - ( src._11 * src._02 ) );
			double c21 = ( ( src._00 * src._12 ) - ( src._10 * src._02 ) );
			double c22 = ( ( src._00 * src._11 ) - ( src._10 * src._01 ) );
			double invdet = ( 1.0 / det );
			dest._00 = ( c00 * invdet );
			dest._01 = (  - (c01)  * invdet );
			dest._02 = ( c02 * invdet );
			dest._10 = (  - (c10)  * invdet );
			dest._11 = ( c11 * invdet );
			dest._12 = (  - (c12)  * invdet );
			dest._20 = ( c20 * invdet );
			dest._21 = (  - (c21)  * invdet );
			dest._22 = ( c22 * invdet );
			return dest;
		}
		
		
		public static global::glm.Mat3 multMat(global::glm.Mat3 a, global::glm.Mat3 b, global::glm.Mat3 dest) {
			global::glm.Mat3 _a = null;
			global::glm.Mat3 _b = null;
			if (( dest == a )) {
				global::glm.Mat3 dest1 = new global::glm.Mat3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
				dest1._00 = a._00;
				dest1._10 = a._10;
				dest1._20 = a._20;
				dest1._01 = a._01;
				dest1._11 = a._11;
				dest1._21 = a._21;
				dest1._02 = a._02;
				dest1._12 = a._12;
				dest1._22 = a._22;
				_a = dest1;
				_b = b;
			}
			else if (( dest == b )) {
				_a = a;
				global::glm.Mat3 dest2 = new global::glm.Mat3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
				dest2._00 = b._00;
				dest2._10 = b._10;
				dest2._20 = b._20;
				dest2._01 = b._01;
				dest2._11 = b._11;
				dest2._21 = b._21;
				dest2._02 = b._02;
				dest2._12 = b._12;
				dest2._22 = b._22;
				_b = dest2;
			}
			else {
				_a = a;
				_b = b;
			}
			
			dest._00 = ( ( ( _a._00 * _b._00 ) + ( _a._10 * _b._01 ) ) + ( _a._20 * _b._02 ) );
			dest._10 = ( ( ( _a._00 * _b._10 ) + ( _a._10 * _b._11 ) ) + ( _a._20 * _b._12 ) );
			dest._20 = ( ( ( _a._00 * _b._20 ) + ( _a._10 * _b._21 ) ) + ( _a._20 * _b._22 ) );
			dest._01 = ( ( ( _a._01 * _b._00 ) + ( _a._11 * _b._01 ) ) + ( _a._21 * _b._02 ) );
			dest._11 = ( ( ( _a._01 * _b._10 ) + ( _a._11 * _b._11 ) ) + ( _a._21 * _b._12 ) );
			dest._21 = ( ( ( _a._01 * _b._20 ) + ( _a._11 * _b._21 ) ) + ( _a._21 * _b._22 ) );
			dest._02 = ( ( ( _a._02 * _b._00 ) + ( _a._12 * _b._01 ) ) + ( _a._22 * _b._02 ) );
			dest._12 = ( ( ( _a._02 * _b._10 ) + ( _a._12 * _b._11 ) ) + ( _a._22 * _b._12 ) );
			dest._22 = ( ( ( _a._02 * _b._20 ) + ( _a._12 * _b._21 ) ) + ( _a._22 * _b._22 ) );
			return dest;
		}
		
		
		public static global::glm.Mat3 multMatOp(global::glm.Mat3 a, global::glm.Mat3 b) {
			global::glm.Mat3 dest = new global::glm.Mat3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			global::glm.Mat3 _a = null;
			global::glm.Mat3 _b = null;
			if (( dest == a )) {
				global::glm.Mat3 dest1 = new global::glm.Mat3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
				dest1._00 = a._00;
				dest1._10 = a._10;
				dest1._20 = a._20;
				dest1._01 = a._01;
				dest1._11 = a._11;
				dest1._21 = a._21;
				dest1._02 = a._02;
				dest1._12 = a._12;
				dest1._22 = a._22;
				_a = dest1;
				_b = b;
			}
			else if (( dest == b )) {
				_a = a;
				global::glm.Mat3 dest2 = new global::glm.Mat3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
				dest2._00 = b._00;
				dest2._10 = b._10;
				dest2._20 = b._20;
				dest2._01 = b._01;
				dest2._11 = b._11;
				dest2._21 = b._21;
				dest2._02 = b._02;
				dest2._12 = b._12;
				dest2._22 = b._22;
				_b = dest2;
			}
			else {
				_a = a;
				_b = b;
			}
			
			dest._00 = ( ( ( _a._00 * _b._00 ) + ( _a._10 * _b._01 ) ) + ( _a._20 * _b._02 ) );
			dest._10 = ( ( ( _a._00 * _b._10 ) + ( _a._10 * _b._11 ) ) + ( _a._20 * _b._12 ) );
			dest._20 = ( ( ( _a._00 * _b._20 ) + ( _a._10 * _b._21 ) ) + ( _a._20 * _b._22 ) );
			dest._01 = ( ( ( _a._01 * _b._00 ) + ( _a._11 * _b._01 ) ) + ( _a._21 * _b._02 ) );
			dest._11 = ( ( ( _a._01 * _b._10 ) + ( _a._11 * _b._11 ) ) + ( _a._21 * _b._12 ) );
			dest._21 = ( ( ( _a._01 * _b._20 ) + ( _a._11 * _b._21 ) ) + ( _a._21 * _b._22 ) );
			dest._02 = ( ( ( _a._02 * _b._00 ) + ( _a._12 * _b._01 ) ) + ( _a._22 * _b._02 ) );
			dest._12 = ( ( ( _a._02 * _b._10 ) + ( _a._12 * _b._11 ) ) + ( _a._22 * _b._12 ) );
			dest._22 = ( ( ( _a._02 * _b._20 ) + ( _a._12 * _b._21 ) ) + ( _a._22 * _b._22 ) );
			return dest;
		}
		
		
		public static global::glm.Vec3 multVec(global::glm.Mat3 m, global::glm.Vec3 v, global::glm.Vec3 dest) {
			double x = v.x;
			double y = v.y;
			double z = v.z;
			dest.x = ( ( ( m._00 * x ) + ( m._10 * y ) ) + ( m._20 * z ) );
			dest.y = ( ( ( m._01 * x ) + ( m._11 * y ) ) + ( m._21 * z ) );
			dest.z = ( ( ( m._02 * x ) + ( m._12 * y ) ) + ( m._22 * z ) );
			return dest;
		}
		
		
		public static global::glm.Vec3 multVecOp(global::glm.Mat3 m, global::glm.Vec3 v) {
			global::glm.Vec3 dest = new global::glm.Vec3(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			double x = v.x;
			double y = v.y;
			double z = v.z;
			dest.x = ( ( ( m._00 * x ) + ( m._10 * y ) ) + ( m._20 * z ) );
			dest.y = ( ( ( m._01 * x ) + ( m._11 * y ) ) + ( m._21 * z ) );
			dest.z = ( ( ( m._02 * x ) + ( m._12 * y ) ) + ( m._22 * z ) );
			return dest;
		}
		
		
		public static global::glm.Mat3 fromFloatArray(global::haxe.root.Array<double> arr) {
			unchecked {
				return new global::glm.Mat3(new global::haxe.lang.Null<double>(arr[0], true), new global::haxe.lang.Null<double>(arr[3], true), new global::haxe.lang.Null<double>(arr[6], true), new global::haxe.lang.Null<double>(arr[1], true), new global::haxe.lang.Null<double>(arr[4], true), new global::haxe.lang.Null<double>(arr[7], true), new global::haxe.lang.Null<double>(arr[2], true), new global::haxe.lang.Null<double>(arr[5], true), new global::haxe.lang.Null<double>(arr[8], true));
			}
		}
		
		
		public double _00;
		
		public double _10;
		
		public double _20;
		
		public double _01;
		
		public double _11;
		
		public double _21;
		
		public double _02;
		
		public double _12;
		
		public double _22;
		
		
		
		public double get_r0c0() {
			return this._00;
		}
		
		
		public double set_r0c0(double v) {
			return this._00 = v;
		}
		
		
		
		
		public double get_r1c0() {
			return this._01;
		}
		
		
		public double set_r1c0(double v) {
			return this._01 = v;
		}
		
		
		
		
		public double get_r2c0() {
			return this._02;
		}
		
		
		public double set_r2c0(double v) {
			return this._02 = v;
		}
		
		
		
		
		public double get_r0c1() {
			return this._10;
		}
		
		
		public double set_r0c1(double v) {
			return this._10 = v;
		}
		
		
		
		
		public double get_r1c1() {
			return this._11;
		}
		
		
		public double set_r1c1(double v) {
			return this._11 = v;
		}
		
		
		
		
		public double get_r2c1() {
			return this._12;
		}
		
		
		public double set_r2c1(double v) {
			return this._12 = v;
		}
		
		
		
		
		public double get_r0c2() {
			return this._20;
		}
		
		
		public double set_r0c2(double v) {
			return this._20 = v;
		}
		
		
		
		
		public double get_r1c2() {
			return this._21;
		}
		
		
		public double set_r1c2(double v) {
			return this._21 = v;
		}
		
		
		
		
		public double get_r2c2() {
			return this._22;
		}
		
		
		public double set_r2c2(double v) {
			return this._22 = v;
		}
		
		
		public double @get(int key) {
			unchecked {
				switch (key) {
					case 0:
					{
						return this._00;
					}
					
					
					case 1:
					{
						return this._01;
					}
					
					
					case 2:
					{
						return this._02;
					}
					
					
					case 3:
					{
						return this._10;
					}
					
					
					case 4:
					{
						return this._11;
					}
					
					
					case 5:
					{
						return this._12;
					}
					
					
					case 6:
					{
						return this._20;
					}
					
					
					case 7:
					{
						return this._21;
					}
					
					
					case 8:
					{
						return this._22;
					}
					
					
					default:
					{
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Index ", global::haxe.lang.Runtime.toString(key)), " out of bounds (0-8)!"));
					}
					
				}
				
			}
		}
		
		
		public double arrayWrite(int key, double @value) {
			unchecked {
				switch (key) {
					case 0:
					{
						return this._00 = @value;
					}
					
					
					case 1:
					{
						return this._01 = @value;
					}
					
					
					case 2:
					{
						return this._02 = @value;
					}
					
					
					case 3:
					{
						return this._10 = @value;
					}
					
					
					case 4:
					{
						return this._11 = @value;
					}
					
					
					case 5:
					{
						return this._12 = @value;
					}
					
					
					case 6:
					{
						return this._20 = @value;
					}
					
					
					case 7:
					{
						return this._21 = @value;
					}
					
					
					case 8:
					{
						return this._22 = @value;
					}
					
					
					default:
					{
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Index ", global::haxe.lang.Runtime.toString(key)), " out of bounds (0-8)!"));
					}
					
				}
				
			}
		}
		
		
		public bool @equals(global::glm.Mat3 b) {
			return  ! ((( ( ( ( ( ( ( ( ( global::System.Math.Abs(((double) (( this._00 - b._00 )) )) >= global::glm.GLM.EPSILON ) || ( global::System.Math.Abs(((double) (( this._10 - b._10 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._20 - b._20 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._01 - b._01 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._11 - b._11 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._21 - b._21 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._02 - b._02 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._12 - b._12 )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this._22 - b._22 )) )) >= global::glm.GLM.EPSILON ) ))) ;
		}
		
		
		public string toString() {
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("[", global::haxe.lang.Runtime.toString(this._00)), ", "), global::haxe.lang.Runtime.toString(this._10)), ", "), global::haxe.lang.Runtime.toString(this._20)), "]\n"), (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("[", global::haxe.lang.Runtime.toString(this._01)), ", "), global::haxe.lang.Runtime.toString(this._11)), ", "), global::haxe.lang.Runtime.toString(this._21)), "]\n"))), (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("[", global::haxe.lang.Runtime.toString(this._02)), ", "), global::haxe.lang.Runtime.toString(this._12)), ", "), global::haxe.lang.Runtime.toString(this._22)), "]\n")));
		}
		
		
		public global::haxe.root.Array<double> toFloatArray() {
			return new global::haxe.root.Array<double>(new double[]{this._00, this._01, this._02, this._10, this._11, this._12, this._20, this._21, this._22});
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1266719215:
					{
						this.set_r2c2(@value);
						return @value;
					}
					
					
					case 1266669486:
					{
						this.set_r1c2(@value);
						return @value;
					}
					
					
					case 1266619757:
					{
						this.set_r0c2(@value);
						return @value;
					}
					
					
					case 1266719214:
					{
						this.set_r2c1(@value);
						return @value;
					}
					
					
					case 1266669485:
					{
						this.set_r1c1(@value);
						return @value;
					}
					
					
					case 1266619756:
					{
						this.set_r0c1(@value);
						return @value;
					}
					
					
					case 1266719213:
					{
						this.set_r2c0(@value);
						return @value;
					}
					
					
					case 1266669484:
					{
						this.set_r1c0(@value);
						return @value;
					}
					
					
					case 1266619755:
					{
						this.set_r0c0(@value);
						return @value;
					}
					
					
					case 4735455:
					{
						this._22 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735232:
					{
						this._12 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735009:
					{
						this._02 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735454:
					{
						this._21 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735231:
					{
						this._11 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735008:
					{
						this._01 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735453:
					{
						this._20 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735230:
					{
						this._10 = ((double) (@value) );
						return @value;
					}
					
					
					case 4735007:
					{
						this._00 = ((double) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1266719215:
					{
						this.set_r2c2(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266669486:
					{
						this.set_r1c2(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266619757:
					{
						this.set_r0c2(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266719214:
					{
						this.set_r2c1(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266669485:
					{
						this.set_r1c1(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266619756:
					{
						this.set_r0c1(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266719213:
					{
						this.set_r2c0(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266669484:
					{
						this.set_r1c0(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 1266619755:
					{
						this.set_r0c0(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 4735455:
					{
						this._22 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735232:
					{
						this._12 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735009:
					{
						this._02 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735454:
					{
						this._21 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735231:
					{
						this._11 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735008:
					{
						this._01 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735453:
					{
						this._20 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735230:
					{
						this._10 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 4735007:
					{
						this._00 = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1711764408:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toFloatArray", 1711764408)) );
					}
					
					
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1072885311:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "equals", 1072885311)) );
					}
					
					
					case 1250329734:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "arrayWrite", 1250329734)) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 2040049388:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r2c2", 2040049388)) );
					}
					
					
					case 1262179704:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r2c2", 1262179704)) );
					}
					
					
					case 1266719215:
					{
						return this.get_r2c2();
					}
					
					
					case 2039999659:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r1c2", 2039999659)) );
					}
					
					
					case 1262129975:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r1c2", 1262129975)) );
					}
					
					
					case 1266669486:
					{
						return this.get_r1c2();
					}
					
					
					case 2039949930:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r0c2", 2039949930)) );
					}
					
					
					case 1262080246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r0c2", 1262080246)) );
					}
					
					
					case 1266619757:
					{
						return this.get_r0c2();
					}
					
					
					case 2040049387:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r2c1", 2040049387)) );
					}
					
					
					case 1262179703:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r2c1", 1262179703)) );
					}
					
					
					case 1266719214:
					{
						return this.get_r2c1();
					}
					
					
					case 2039999658:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r1c1", 2039999658)) );
					}
					
					
					case 1262129974:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r1c1", 1262129974)) );
					}
					
					
					case 1266669485:
					{
						return this.get_r1c1();
					}
					
					
					case 2039949929:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r0c1", 2039949929)) );
					}
					
					
					case 1262080245:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r0c1", 1262080245)) );
					}
					
					
					case 1266619756:
					{
						return this.get_r0c1();
					}
					
					
					case 2040049386:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r2c0", 2040049386)) );
					}
					
					
					case 1262179702:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r2c0", 1262179702)) );
					}
					
					
					case 1266719213:
					{
						return this.get_r2c0();
					}
					
					
					case 2039999657:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r1c0", 2039999657)) );
					}
					
					
					case 1262129973:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r1c0", 1262129973)) );
					}
					
					
					case 1266669484:
					{
						return this.get_r1c0();
					}
					
					
					case 2039949928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r0c0", 2039949928)) );
					}
					
					
					case 1262080244:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r0c0", 1262080244)) );
					}
					
					
					case 1266619755:
					{
						return this.get_r0c0();
					}
					
					
					case 4735455:
					{
						return this._22;
					}
					
					
					case 4735232:
					{
						return this._12;
					}
					
					
					case 4735009:
					{
						return this._02;
					}
					
					
					case 4735454:
					{
						return this._21;
					}
					
					
					case 4735231:
					{
						return this._11;
					}
					
					
					case 4735008:
					{
						return this._01;
					}
					
					
					case 4735453:
					{
						return this._20;
					}
					
					
					case 4735230:
					{
						return this._10;
					}
					
					
					case 4735007:
					{
						return this._00;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1266719215:
					{
						return this.get_r2c2();
					}
					
					
					case 1266669486:
					{
						return this.get_r1c2();
					}
					
					
					case 1266619757:
					{
						return this.get_r0c2();
					}
					
					
					case 1266719214:
					{
						return this.get_r2c1();
					}
					
					
					case 1266669485:
					{
						return this.get_r1c1();
					}
					
					
					case 1266619756:
					{
						return this.get_r0c1();
					}
					
					
					case 1266719213:
					{
						return this.get_r2c0();
					}
					
					
					case 1266669484:
					{
						return this.get_r1c0();
					}
					
					
					case 1266619755:
					{
						return this.get_r0c0();
					}
					
					
					case 4735455:
					{
						return this._22;
					}
					
					
					case 4735232:
					{
						return this._12;
					}
					
					
					case 4735009:
					{
						return this._02;
					}
					
					
					case 4735454:
					{
						return this._21;
					}
					
					
					case 4735231:
					{
						return this._11;
					}
					
					
					case 4735008:
					{
						return this._01;
					}
					
					
					case 4735453:
					{
						return this._20;
					}
					
					
					case 4735230:
					{
						return this._10;
					}
					
					
					case 4735007:
					{
						return this._00;
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs) {
			unchecked {
				switch (hash) {
					case 1711764408:
					{
						return this.toFloatArray();
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1072885311:
					{
						return this.@equals(((global::glm.Mat3) (dynargs[0]) ));
					}
					
					
					case 1250329734:
					{
						return this.arrayWrite(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
					}
					
					
					case 5144726:
					{
						return this.@get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 2040049388:
					{
						return this.set_r2c2(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262179704:
					{
						return this.get_r2c2();
					}
					
					
					case 2039999659:
					{
						return this.set_r1c2(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262129975:
					{
						return this.get_r1c2();
					}
					
					
					case 2039949930:
					{
						return this.set_r0c2(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262080246:
					{
						return this.get_r0c2();
					}
					
					
					case 2040049387:
					{
						return this.set_r2c1(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262179703:
					{
						return this.get_r2c1();
					}
					
					
					case 2039999658:
					{
						return this.set_r1c1(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262129974:
					{
						return this.get_r1c1();
					}
					
					
					case 2039949929:
					{
						return this.set_r0c1(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262080245:
					{
						return this.get_r0c1();
					}
					
					
					case 2040049386:
					{
						return this.set_r2c0(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262179702:
					{
						return this.get_r2c0();
					}
					
					
					case 2039999657:
					{
						return this.set_r1c0(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262129973:
					{
						return this.get_r1c0();
					}
					
					
					case 2039949928:
					{
						return this.set_r0c0(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 1262080244:
					{
						return this.get_r0c0();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("r2c2");
			baseArr.push("r1c2");
			baseArr.push("r0c2");
			baseArr.push("r2c1");
			baseArr.push("r1c1");
			baseArr.push("r0c1");
			baseArr.push("r2c0");
			baseArr.push("r1c0");
			baseArr.push("r0c0");
			baseArr.push("_22");
			baseArr.push("_12");
			baseArr.push("_02");
			baseArr.push("_21");
			baseArr.push("_11");
			baseArr.push("_01");
			baseArr.push("_20");
			baseArr.push("_10");
			baseArr.push("_00");
			base.__hx_getFields(baseArr);
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


