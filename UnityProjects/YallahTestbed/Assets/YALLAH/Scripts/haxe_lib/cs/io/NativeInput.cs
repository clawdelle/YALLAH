// Generated by Haxe 3.4.7
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io {
	public class NativeInput : global::haxe.io.Input {
		
		public NativeInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public NativeInput(global::System.IO.Stream stream) {
			global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(this, stream);
		}
		
		
		public static void __hx_ctor_cs_io_NativeInput(global::cs.io.NativeInput __hx_this, global::System.IO.Stream stream) {
			__hx_this.stream = stream;
			__hx_this._eof = false;
			if ( ! (stream.CanRead) ) {
				throw global::haxe.lang.HaxeException.wrap("Write-only stream");
			}
			
		}
		
		
		
		
		public global::System.IO.Stream stream;
		
		public bool _eof;
		
		public override int readByte() {
			unchecked {
				int ret = this.stream.ReadByte();
				if (( ret == -1 )) {
					this._eof = true;
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
				}
				
				return ret;
			}
		}
		
		
		public override int readBytes(global::haxe.io.Bytes s, int pos, int len) {
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
			}
			
			int ret = this.stream.Read(((byte[]) (s.b) ), ((int) (pos) ), ((int) (len) ));
			if (( ret == 0 )) {
				this._eof = true;
				throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
			}
			
			return ret;
		}
		
		
		public virtual void close() {
			this.stream.Close();
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1058556349:
					{
						this._eof = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
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
					case 1214453688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 243225909:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readBytes", 243225909)) );
					}
					
					
					case 1763375486:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readByte", 1763375486)) );
					}
					
					
					case 1058556349:
					{
						return this._eof;
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
					case 1763375486:
					case 243225909:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
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
			baseArr.push("_eof");
			baseArr.push("stream");
			baseArr.push("canSeek");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


