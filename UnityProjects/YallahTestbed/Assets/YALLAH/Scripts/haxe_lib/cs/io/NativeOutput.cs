// Generated by Haxe 3.4.2
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io {
	public class NativeOutput : global::haxe.io.Output {
		
		public NativeOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public NativeOutput(global::System.IO.Stream stream) {
			global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(this, stream);
		}
		
		
		public static void __hx_ctor_cs_io_NativeOutput(global::cs.io.NativeOutput __hx_this, global::System.IO.Stream stream) {
			__hx_this.stream = stream;
			if ( ! (stream.CanWrite) ) {
				throw global::haxe.lang.HaxeException.wrap("Read-only stream");
			}
			
		}
		
		
		
		
		public global::System.IO.Stream stream;
		
		public override void writeByte(int c) {
			this.stream.WriteByte(((byte) (c) ));
		}
		
		
		public virtual void close() {
			this.stream.Close();
		}
		
		
		public virtual void flush() {
			this.stream.Flush();
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 288167040:
					{
						this.stream = ((global::System.IO.Stream) (@value) );
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
					case 43737796:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "flush", 43737796)) );
					}
					
					
					case 1214453688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeByte", 1238832007)) );
					}
					
					
					case 288167040:
					{
						return this.stream;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs) {
			unchecked {
				switch (hash) {
					case 1238832007:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 43737796:
					{
						this.flush();
						break;
					}
					
					
					case 1214453688:
					{
						this.close();
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("stream");
			baseArr.push("canSeek");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


