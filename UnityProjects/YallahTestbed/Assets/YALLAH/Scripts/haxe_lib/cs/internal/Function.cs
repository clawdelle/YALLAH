// Generated by Haxe 3.4.2
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Function {
		
		public Function(int arity, int type) {
			this.__fn_type = type;
			this.__hx_arity = arity;
		}
		
		
		public virtual object __hx_invokeDynamic(global::haxe.root.Array __fn_dynargs) {
			unchecked {
				switch (( (( __fn_dynargs == null )) ? (0) : (((int) (global::haxe.lang.Runtime.getField_f(__fn_dynargs, "length", 520590566, true)) )) )) {
					case 0:
					{
						return this.__hx_invoke0_o();
					}
					
					
					case 1:
					{
						return this.__hx_invoke1_o(0.0, ((object) (__fn_dynargs[0]) ));
					}
					
					
					case 2:
					{
						return this.__hx_invoke2_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ));
					}
					
					
					case 3:
					{
						return this.__hx_invoke3_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ));
					}
					
					
					case 4:
					{
						return this.__hx_invoke4_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ));
					}
					
					
					case 5:
					{
						return this.__hx_invoke5_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ), 0.0, ((object) (__fn_dynargs[4]) ));
					}
					
					
					case 6:
					{
						return this.__hx_invoke6_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ), 0.0, ((object) (__fn_dynargs[4]) ), 0.0, ((object) (__fn_dynargs[5]) ));
					}
					
					
					default:
					{
						throw global::haxe.lang.HaxeException.wrap("Too many arguments");
					}
					
				}
				
			}
		}
		
		
		public int __fn_type;
		
		public int __hx_arity;
		
		public virtual object __hx_invoke6_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke6_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5, __fn_float6, __fn_dyn6);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke6_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke6_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5, __fn_float6, __fn_dyn6))) );
			}
			
		}
		
		
		public virtual object __hx_invoke5_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke5_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke5_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke5_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5))) );
			}
			
		}
		
		
		public virtual object __hx_invoke4_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke4_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke4_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke4_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4))) );
			}
			
		}
		
		
		public virtual object __hx_invoke3_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke3_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke3_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke3_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3))) );
			}
			
		}
		
		
		public virtual object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke2_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke2_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke2_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2))) );
			}
			
		}
		
		
		public virtual object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke1_f(__fn_float1, __fn_dyn1);
				}
				
			}
		}
		
		
		public virtual double __hx_invoke1_f(double __fn_float1, object __fn_dyn1) {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke1_o(__fn_float1, __fn_dyn1))) );
			}
			
		}
		
		
		public virtual object __hx_invoke0_o() {
			unchecked {
				if (( this.__fn_type != 1 )) {
					throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				else {
					return this.__hx_invoke0_f();
				}
				
			}
		}
		
		
		public virtual double __hx_invoke0_f() {
			if (( this.__fn_type != 0 )) {
				throw global::haxe.lang.HaxeException.wrap("Wrong number of arguments");
			}
			else {
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke0_o())) );
			}
			
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class VarArgsBase : global::haxe.lang.Function {
		
		public VarArgsBase(int arity, int type) : base(arity, type) {
		}
		
		
		public override object __hx_invokeDynamic(global::haxe.root.Array dynArgs) {
			throw global::haxe.lang.HaxeException.wrap("Abstract implementation");
		}
		
		
		public override object __hx_invoke6_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) ), ( (( __fn_dyn6 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float6) ) : (((object) (__fn_dyn6) )) )}));
		}
		
		
		public override double __hx_invoke6_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) ), ( (( __fn_dyn6 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float6) ) : (((object) (__fn_dyn6) )) )})))) );
		}
		
		
		public override object __hx_invoke5_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) )}));
		}
		
		
		public override double __hx_invoke5_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) )})))) );
		}
		
		
		public override object __hx_invoke4_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) )}));
		}
		
		
		public override double __hx_invoke4_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) )})))) );
		}
		
		
		public override object __hx_invoke3_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) )}));
		}
		
		
		public override double __hx_invoke3_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) )})))) );
		}
		
		
		public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) )}));
		}
		
		
		public override double __hx_invoke2_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) )})))) );
		}
		
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			return this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) )}));
		}
		
		
		public override double __hx_invoke1_f(double __fn_float1, object __fn_dyn1) {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new global::haxe.root.Array<object>(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) )})))) );
		}
		
		
		public override object __hx_invoke0_o() {
			return this.__hx_invokeDynamic(null);
		}
		
		
		public override double __hx_invoke0_f() {
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(null))) );
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class VarArgsFunction : global::haxe.lang.VarArgsBase {
		
		public VarArgsFunction(global::haxe.lang.Function fun) : base(-1, -1) {
			this.fun = fun;
		}
		
		
		public global::haxe.lang.Function fun;
		
		public override object __hx_invokeDynamic(global::haxe.root.Array dynArgs) {
			return ((object) (this.fun.__hx_invoke1_o(default(double), dynArgs)) );
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Closure : global::haxe.lang.VarArgsBase {
		
		public Closure(object obj, string field, int hash) : base(-1, -1) {
			this.obj = obj;
			this.field = field;
			this.hash = hash;
		}
		
		
		public object obj;
		
		public string field;
		
		public int hash;
		
		public override object __hx_invokeDynamic(global::haxe.root.Array dynArgs) {
			return global::haxe.lang.Runtime.callField(this.obj, this.field, this.hash, dynArgs);
		}
		
		
		public override bool Equals(object obj) {
			global::haxe.lang.Closure c = ((global::haxe.lang.Closure) (( obj as global::haxe.lang.Closure )) );
			if (( c == null )) {
				return false;
			}
			
			if (global::haxe.lang.Runtime.eq(c.obj, this.obj)) {
				return string.Equals(c.field, this.field);
			}
			else {
				return false;
			}
			
		}
		
		
		public override int GetHashCode() {
			return ( ((int) (global::haxe.lang.Runtime.toInt(this.obj.GetHashCode())) ) ^ ((int) (this.field.GetHashCode()) ) );
		}
		
		
	}
}


