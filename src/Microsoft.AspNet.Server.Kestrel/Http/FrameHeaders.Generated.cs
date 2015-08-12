
using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.Server.Kestrel.Http 
{
    public partial class FrameResponseHeaders
    {
        public FrameResponseHeaders()
        {
            _Server = new[] { "Kestrel" };
            _Date = new[] { GetDateHeaderValue() };
            _bits = 67108868L;
        }
    }

    public partial class FrameRequestHeaders 
    {
        long _bits = 0;
        
        string[] _CacheControl;
        string[] _Connection;
        string[] _Date;
        string[] _KeepAlive;
        string[] _Pragma;
        string[] _Trailer;
        string[] _TransferEncoding;
        string[] _Upgrade;
        string[] _Via;
        string[] _Warning;
        string[] _Allow;
        string[] _ContentLength;
        string[] _ContentType;
        string[] _ContentEncoding;
        string[] _ContentLanguage;
        string[] _ContentLocation;
        string[] _ContentMD5;
        string[] _ContentRange;
        string[] _Expires;
        string[] _LastModified;
        string[] _Accept;
        string[] _AcceptCharset;
        string[] _AcceptEncoding;
        string[] _AcceptLanguage;
        string[] _Authorization;
        string[] _Cookie;
        string[] _Expect;
        string[] _From;
        string[] _Host;
        string[] _IfMatch;
        string[] _IfModifiedSince;
        string[] _IfNoneMatch;
        string[] _IfRange;
        string[] _IfUnmodifiedSince;
        string[] _MaxForwards;
        string[] _ProxyAuthorization;
        string[] _Referer;
        string[] _Range;
        string[] _TE;
        string[] _Translate;
        string[] _UserAgent;

        protected override int GetCountFast()
        {
            var count = MaybeUnknown?.Count ?? 0;
            
                if (((_bits & 1L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 32L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 64L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 128L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 256L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 512L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1024L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2048L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4096L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8192L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16384L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 32768L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 65536L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 131072L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 262144L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 524288L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1048576L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2097152L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4194304L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8388608L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16777216L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 33554432L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 67108864L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 134217728L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 268435456L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 536870912L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1073741824L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2147483648L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4294967296L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8589934592L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 17179869184L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 34359738368L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 68719476736L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 137438953472L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 274877906944L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 549755813888L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1099511627776L) != 0)) 
                {
                    ++count;
                }
            
            return count;
        }

        protected override string[] GetValueFast(string key)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                return _CacheControl;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                return _ContentRange;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                return _LastModified;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                return _Authorization;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("If-None-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2147483648L) != 0))
                            {
                                return _IfNoneMatch;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                return _Connection;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                return _KeepAlive;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("User-Agent".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1099511627776L) != 0))
                            {
                                return _UserAgent;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                return _Date;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("From".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                return _From;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Host".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                return _Host;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                return _Pragma;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Accept".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                return _Accept;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                return _Cookie;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Expect".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                return _Expect;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                return _Trailer;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                return _Upgrade;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                return _Warning;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                return _Expires;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Referer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 68719476736L) != 0))
                            {
                                return _Referer;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                return _TransferEncoding;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("If-Modified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1073741824L) != 0))
                            {
                                return _IfModifiedSince;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                return _Via;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                return _Allow;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 137438953472L) != 0))
                            {
                                return _Range;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                return _ContentLength;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Accept-Charset".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                return _AcceptCharset;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                return _ContentType;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Max-Forwards".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 17179869184L) != 0))
                            {
                                return _MaxForwards;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                return _ContentEncoding;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                return _ContentLanguage;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                return _ContentLocation;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                return _ContentMD5;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ("Accept-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                return _AcceptEncoding;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Accept-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                return _AcceptLanguage;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("If-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                return _IfMatch;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("If-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4294967296L) != 0))
                            {
                                return _IfRange;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ("If-Unmodified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8589934592L) != 0))
                            {
                                return _IfUnmodifiedSince;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Proxy-Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 34359738368L) != 0))
                            {
                                return _ProxyAuthorization;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ("TE".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 274877906944L) != 0))
                            {
                                return _TE;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ("Translate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 549755813888L) != 0))
                            {
                                return _Translate;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            }
            if (MaybeUnknown == null) 
            {
                throw new System.Collections.Generic.KeyNotFoundException();
            }
            return MaybeUnknown[key];
        }

        protected override bool TryGetValueFast(string key, out string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                value = _CacheControl;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                value = _ContentRange;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                value = _LastModified;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                value = _Authorization;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("If-None-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2147483648L) != 0))
                            {
                                value = _IfNoneMatch;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                value = _Connection;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                value = _KeepAlive;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("User-Agent".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1099511627776L) != 0))
                            {
                                value = _UserAgent;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                value = _Date;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("From".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                value = _From;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Host".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                value = _Host;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                value = _Pragma;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Accept".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                value = _Accept;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                value = _Cookie;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Expect".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                value = _Expect;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                value = _Trailer;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                value = _Upgrade;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                value = _Warning;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                value = _Expires;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Referer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 68719476736L) != 0))
                            {
                                value = _Referer;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                value = _TransferEncoding;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("If-Modified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1073741824L) != 0))
                            {
                                value = _IfModifiedSince;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                value = _Via;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                value = _Allow;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 137438953472L) != 0))
                            {
                                value = _Range;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                value = _ContentLength;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Accept-Charset".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                value = _AcceptCharset;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                value = _ContentType;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Max-Forwards".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 17179869184L) != 0))
                            {
                                value = _MaxForwards;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                value = _ContentEncoding;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                value = _ContentLanguage;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                value = _ContentLocation;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                value = _ContentMD5;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ("Accept-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                value = _AcceptEncoding;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Accept-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                value = _AcceptLanguage;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("If-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                value = _IfMatch;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("If-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4294967296L) != 0))
                            {
                                value = _IfRange;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ("If-Unmodified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8589934592L) != 0))
                            {
                                value = _IfUnmodifiedSince;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Proxy-Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 34359738368L) != 0))
                            {
                                value = _ProxyAuthorization;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ("TE".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 274877906944L) != 0))
                            {
                                value = _TE;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ("Translate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 549755813888L) != 0))
                            {
                                value = _Translate;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            }
            value = null;
            return MaybeUnknown?.TryGetValue(key, out value) ?? false;
        }

        protected override void SetValueFast(string key, string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1L;
                            _CacheControl = value;
                            return;
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 131072L;
                            _ContentRange = value;
                            return;
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 524288L;
                            _LastModified = value;
                            return;
                        }
                    
                        if ("Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16777216L;
                            _Authorization = value;
                            return;
                        }
                    
                        if ("If-None-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2147483648L;
                            _IfNoneMatch = value;
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2L;
                            _Connection = value;
                            return;
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8L;
                            _KeepAlive = value;
                            return;
                        }
                    
                        if ("User-Agent".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1099511627776L;
                            _UserAgent = value;
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4L;
                            _Date = value;
                            return;
                        }
                    
                        if ("From".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 134217728L;
                            _From = value;
                            return;
                        }
                    
                        if ("Host".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 268435456L;
                            _Host = value;
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16L;
                            _Pragma = value;
                            return;
                        }
                    
                        if ("Accept".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1048576L;
                            _Accept = value;
                            return;
                        }
                    
                        if ("Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 33554432L;
                            _Cookie = value;
                            return;
                        }
                    
                        if ("Expect".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 67108864L;
                            _Expect = value;
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 32L;
                            _Trailer = value;
                            return;
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 128L;
                            _Upgrade = value;
                            return;
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 512L;
                            _Warning = value;
                            return;
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 262144L;
                            _Expires = value;
                            return;
                        }
                    
                        if ("Referer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 68719476736L;
                            _Referer = value;
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 64L;
                            _TransferEncoding = value;
                            return;
                        }
                    
                        if ("If-Modified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1073741824L;
                            _IfModifiedSince = value;
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 256L;
                            _Via = value;
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1024L;
                            _Allow = value;
                            return;
                        }
                    
                        if ("Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 137438953472L;
                            _Range = value;
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2048L;
                            _ContentLength = value;
                            return;
                        }
                    
                        if ("Accept-Charset".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2097152L;
                            _AcceptCharset = value;
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4096L;
                            _ContentType = value;
                            return;
                        }
                    
                        if ("Max-Forwards".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 17179869184L;
                            _MaxForwards = value;
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8192L;
                            _ContentEncoding = value;
                            return;
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16384L;
                            _ContentLanguage = value;
                            return;
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 32768L;
                            _ContentLocation = value;
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 65536L;
                            _ContentMD5 = value;
                            return;
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ("Accept-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4194304L;
                            _AcceptEncoding = value;
                            return;
                        }
                    
                        if ("Accept-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8388608L;
                            _AcceptLanguage = value;
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("If-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 536870912L;
                            _IfMatch = value;
                            return;
                        }
                    
                        if ("If-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4294967296L;
                            _IfRange = value;
                            return;
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ("If-Unmodified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8589934592L;
                            _IfUnmodifiedSince = value;
                            return;
                        }
                    
                        if ("Proxy-Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 34359738368L;
                            _ProxyAuthorization = value;
                            return;
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ("TE".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 274877906944L;
                            _TE = value;
                            return;
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ("Translate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 549755813888L;
                            _Translate = value;
                            return;
                        }
                    }
                    break;
            }
            Unknown[key] = value;
        }

        protected override void AddValueFast(string key, string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1L;
                            _CacheControl = value;
                            return;
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 131072L;
                            _ContentRange = value;
                            return;
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 524288L;
                            _LastModified = value;
                            return;
                        }
                    
                        if ("Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16777216L;
                            _Authorization = value;
                            return;
                        }
                    
                        if ("If-None-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2147483648L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2147483648L;
                            _IfNoneMatch = value;
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2L;
                            _Connection = value;
                            return;
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8L;
                            _KeepAlive = value;
                            return;
                        }
                    
                        if ("User-Agent".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1099511627776L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1099511627776L;
                            _UserAgent = value;
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4L;
                            _Date = value;
                            return;
                        }
                    
                        if ("From".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 134217728L;
                            _From = value;
                            return;
                        }
                    
                        if ("Host".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 268435456L;
                            _Host = value;
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16L;
                            _Pragma = value;
                            return;
                        }
                    
                        if ("Accept".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1048576L;
                            _Accept = value;
                            return;
                        }
                    
                        if ("Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 33554432L;
                            _Cookie = value;
                            return;
                        }
                    
                        if ("Expect".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 67108864L;
                            _Expect = value;
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 32L;
                            _Trailer = value;
                            return;
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 128L;
                            _Upgrade = value;
                            return;
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 512L;
                            _Warning = value;
                            return;
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 262144L;
                            _Expires = value;
                            return;
                        }
                    
                        if ("Referer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 68719476736L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 68719476736L;
                            _Referer = value;
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 64L;
                            _TransferEncoding = value;
                            return;
                        }
                    
                        if ("If-Modified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1073741824L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1073741824L;
                            _IfModifiedSince = value;
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 256L;
                            _Via = value;
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1024L;
                            _Allow = value;
                            return;
                        }
                    
                        if ("Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 137438953472L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 137438953472L;
                            _Range = value;
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2048L;
                            _ContentLength = value;
                            return;
                        }
                    
                        if ("Accept-Charset".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2097152L;
                            _AcceptCharset = value;
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4096L;
                            _ContentType = value;
                            return;
                        }
                    
                        if ("Max-Forwards".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 17179869184L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 17179869184L;
                            _MaxForwards = value;
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8192L;
                            _ContentEncoding = value;
                            return;
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16384L;
                            _ContentLanguage = value;
                            return;
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 32768L;
                            _ContentLocation = value;
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 65536L;
                            _ContentMD5 = value;
                            return;
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ("Accept-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4194304L;
                            _AcceptEncoding = value;
                            return;
                        }
                    
                        if ("Accept-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8388608L;
                            _AcceptLanguage = value;
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("If-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 536870912L;
                            _IfMatch = value;
                            return;
                        }
                    
                        if ("If-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4294967296L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4294967296L;
                            _IfRange = value;
                            return;
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ("If-Unmodified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8589934592L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8589934592L;
                            _IfUnmodifiedSince = value;
                            return;
                        }
                    
                        if ("Proxy-Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 34359738368L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 34359738368L;
                            _ProxyAuthorization = value;
                            return;
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ("TE".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 274877906944L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 274877906944L;
                            _TE = value;
                            return;
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ("Translate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 549755813888L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 549755813888L;
                            _Translate = value;
                            return;
                        }
                    }
                    break;
            }
            Unknown.Add(key, value);
        }

        protected override bool RemoveFast(string key)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                _bits &= ~1L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                _bits &= ~131072L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                _bits &= ~524288L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                _bits &= ~16777216L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("If-None-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2147483648L) != 0))
                            {
                                _bits &= ~2147483648L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                _bits &= ~2L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                _bits &= ~8L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("User-Agent".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1099511627776L) != 0))
                            {
                                _bits &= ~1099511627776L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                _bits &= ~4L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("From".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                _bits &= ~134217728L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Host".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                _bits &= ~268435456L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                _bits &= ~16L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Accept".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                _bits &= ~1048576L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                _bits &= ~33554432L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Expect".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                _bits &= ~67108864L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                _bits &= ~32L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                _bits &= ~128L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                _bits &= ~512L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                _bits &= ~262144L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Referer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 68719476736L) != 0))
                            {
                                _bits &= ~68719476736L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                _bits &= ~64L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("If-Modified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1073741824L) != 0))
                            {
                                _bits &= ~1073741824L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                _bits &= ~256L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                _bits &= ~1024L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 137438953472L) != 0))
                            {
                                _bits &= ~137438953472L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                _bits &= ~2048L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Accept-Charset".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                _bits &= ~2097152L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                _bits &= ~4096L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Max-Forwards".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 17179869184L) != 0))
                            {
                                _bits &= ~17179869184L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                _bits &= ~8192L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                _bits &= ~16384L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                _bits &= ~32768L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                _bits &= ~65536L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ("Accept-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                _bits &= ~4194304L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Accept-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                _bits &= ~8388608L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("If-Match".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                _bits &= ~536870912L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("If-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4294967296L) != 0))
                            {
                                _bits &= ~4294967296L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ("If-Unmodified-Since".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8589934592L) != 0))
                            {
                                _bits &= ~8589934592L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Proxy-Authorization".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 34359738368L) != 0))
                            {
                                _bits &= ~34359738368L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ("TE".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 274877906944L) != 0))
                            {
                                _bits &= ~274877906944L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ("Translate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 549755813888L) != 0))
                            {
                                _bits &= ~549755813888L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            }
            return MaybeUnknown?.Remove(key) ?? false;
        }

        protected override void ClearFast()
        {
            _bits = 0;
            MaybeUnknown?.Clear();
        }
        
        protected override void CopyToFast(KeyValuePair<string, string[]>[] array, int arrayIndex)
        {
            if (arrayIndex < 0)
            {
                throw new ArgumentException();
            }

            
                if (((_bits & 1L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Cache-Control", _CacheControl);
                    ++arrayIndex;
                }
            
                if (((_bits & 2L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Connection", _Connection);
                    ++arrayIndex;
                }
            
                if (((_bits & 4L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Date", _Date);
                    ++arrayIndex;
                }
            
                if (((_bits & 8L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Keep-Alive", _KeepAlive);
                    ++arrayIndex;
                }
            
                if (((_bits & 16L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Pragma", _Pragma);
                    ++arrayIndex;
                }
            
                if (((_bits & 32L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Trailer", _Trailer);
                    ++arrayIndex;
                }
            
                if (((_bits & 64L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Transfer-Encoding", _TransferEncoding);
                    ++arrayIndex;
                }
            
                if (((_bits & 128L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Upgrade", _Upgrade);
                    ++arrayIndex;
                }
            
                if (((_bits & 256L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Via", _Via);
                    ++arrayIndex;
                }
            
                if (((_bits & 512L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Warning", _Warning);
                    ++arrayIndex;
                }
            
                if (((_bits & 1024L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Allow", _Allow);
                    ++arrayIndex;
                }
            
                if (((_bits & 2048L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Length", _ContentLength);
                    ++arrayIndex;
                }
            
                if (((_bits & 4096L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Type", _ContentType);
                    ++arrayIndex;
                }
            
                if (((_bits & 8192L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Encoding", _ContentEncoding);
                    ++arrayIndex;
                }
            
                if (((_bits & 16384L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Language", _ContentLanguage);
                    ++arrayIndex;
                }
            
                if (((_bits & 32768L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Location", _ContentLocation);
                    ++arrayIndex;
                }
            
                if (((_bits & 65536L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-MD5", _ContentMD5);
                    ++arrayIndex;
                }
            
                if (((_bits & 131072L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Range", _ContentRange);
                    ++arrayIndex;
                }
            
                if (((_bits & 262144L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Expires", _Expires);
                    ++arrayIndex;
                }
            
                if (((_bits & 524288L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Last-Modified", _LastModified);
                    ++arrayIndex;
                }
            
                if (((_bits & 1048576L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Accept", _Accept);
                    ++arrayIndex;
                }
            
                if (((_bits & 2097152L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Accept-Charset", _AcceptCharset);
                    ++arrayIndex;
                }
            
                if (((_bits & 4194304L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Accept-Encoding", _AcceptEncoding);
                    ++arrayIndex;
                }
            
                if (((_bits & 8388608L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Accept-Language", _AcceptLanguage);
                    ++arrayIndex;
                }
            
                if (((_bits & 16777216L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Authorization", _Authorization);
                    ++arrayIndex;
                }
            
                if (((_bits & 33554432L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Cookie", _Cookie);
                    ++arrayIndex;
                }
            
                if (((_bits & 67108864L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Expect", _Expect);
                    ++arrayIndex;
                }
            
                if (((_bits & 134217728L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("From", _From);
                    ++arrayIndex;
                }
            
                if (((_bits & 268435456L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Host", _Host);
                    ++arrayIndex;
                }
            
                if (((_bits & 536870912L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("If-Match", _IfMatch);
                    ++arrayIndex;
                }
            
                if (((_bits & 1073741824L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("If-Modified-Since", _IfModifiedSince);
                    ++arrayIndex;
                }
            
                if (((_bits & 2147483648L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("If-None-Match", _IfNoneMatch);
                    ++arrayIndex;
                }
            
                if (((_bits & 4294967296L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("If-Range", _IfRange);
                    ++arrayIndex;
                }
            
                if (((_bits & 8589934592L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("If-Unmodified-Since", _IfUnmodifiedSince);
                    ++arrayIndex;
                }
            
                if (((_bits & 17179869184L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Max-Forwards", _MaxForwards);
                    ++arrayIndex;
                }
            
                if (((_bits & 34359738368L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Proxy-Authorization", _ProxyAuthorization);
                    ++arrayIndex;
                }
            
                if (((_bits & 68719476736L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Referer", _Referer);
                    ++arrayIndex;
                }
            
                if (((_bits & 137438953472L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Range", _Range);
                    ++arrayIndex;
                }
            
                if (((_bits & 274877906944L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("TE", _TE);
                    ++arrayIndex;
                }
            
                if (((_bits & 549755813888L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Translate", _Translate);
                    ++arrayIndex;
                }
            
                if (((_bits & 1099511627776L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("User-Agent", _UserAgent);
                    ++arrayIndex;
                }
            
            ((ICollection<KeyValuePair<string, string[]>>)MaybeUnknown)?.CopyTo(array, arrayIndex);
        }

        public unsafe void Append(byte[] keyBytes, int keyOffset, int keyLength, string value)
        {
            fixed(byte* ptr = keyBytes) { var pUB = ptr + keyOffset; var pUL = (ulong*)pUB; var pUI = (uint*)pUB; var pUS = (ushort*)pUB;
            switch(keyLength)
            {
                case 13:
                    {
                        if ((((pUL[0] & 16131893727263186911uL) == 5711458528024281411uL) && ((pUI[2] & 3755991007u) == 1330795598u) && ((pUB[12] & 223u) == 76u))) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                _CacheControl = AppendValue(_CacheControl, value);
                            }
                            else
                            {
                                _bits |= 1L;
                                _CacheControl = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1196310866u) && ((pUB[12] & 223u) == 69u))) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                _ContentRange = AppendValue(_ContentRange, value);
                            }
                            else
                            {
                                _bits |= 131072L;
                                _ContentRange = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858680330051551uL) == 4922237774822850892uL) && ((pUI[2] & 3755991007u) == 1162430025u) && ((pUB[12] & 223u) == 68u))) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                _LastModified = AppendValue(_LastModified, value);
                            }
                            else
                            {
                                _bits |= 524288L;
                                _LastModified = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858542891098079uL) == 6505821637182772545uL) && ((pUI[2] & 3755991007u) == 1330205761u) && ((pUB[12] & 223u) == 78u))) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                _Authorization = AppendValue(_Authorization, value);
                            }
                            else
                            {
                                _bits |= 16777216L;
                                _Authorization = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552106889183uL) == 3262099607620765257uL) && ((pUI[2] & 3755991007u) == 1129595213u) && ((pUB[12] & 223u) == 72u))) 
                        {
                            if (((_bits & 2147483648L) != 0))
                            {
                                _IfNoneMatch = AppendValue(_IfNoneMatch, value);
                            }
                            else
                            {
                                _bits |= 2147483648L;
                                _IfNoneMatch = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 5283922227757993795uL) && ((pUS[4] & 57311u) == 20047u))) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                _Connection = AppendValue(_Connection, value);
                            }
                            else
                            {
                                _bits |= 2L;
                                _Connection = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858680330051551uL) == 5281668125874799947uL) && ((pUS[4] & 57311u) == 17750u))) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                _KeepAlive = AppendValue(_KeepAlive, value);
                            }
                            else
                            {
                                _bits |= 8L;
                                _KeepAlive = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858680330051551uL) == 4992030374873092949uL) && ((pUS[4] & 57311u) == 21582u))) 
                        {
                            if (((_bits & 1099511627776L) != 0))
                            {
                                _UserAgent = AppendValue(_UserAgent, value);
                            }
                            else
                            {
                                _bits |= 1099511627776L;
                                _UserAgent = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ((((pUI[0] & 3755991007u) == 1163149636u))) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                _Date = AppendValue(_Date, value);
                            }
                            else
                            {
                                _bits |= 4L;
                                _Date = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1297044038u))) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                _From = AppendValue(_From, value);
                            }
                            else
                            {
                                _bits |= 134217728L;
                                _From = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1414745928u))) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                _Host = AppendValue(_Host, value);
                            }
                            else
                            {
                                _bits |= 268435456L;
                                _Host = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ((((pUI[0] & 3755991007u) == 1195463248u) && ((pUS[2] & 57311u) == 16717u))) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                _Pragma = AppendValue(_Pragma, value);
                            }
                            else
                            {
                                _bits |= 16L;
                                _Pragma = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1162036033u) && ((pUS[2] & 57311u) == 21584u))) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                _Accept = AppendValue(_Accept, value);
                            }
                            else
                            {
                                _bits |= 1048576L;
                                _Accept = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1263488835u) && ((pUS[2] & 57311u) == 17737u))) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                _Cookie = AppendValue(_Cookie, value);
                            }
                            else
                            {
                                _bits |= 33554432L;
                                _Cookie = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1162893381u) && ((pUS[2] & 57311u) == 21571u))) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                _Expect = AppendValue(_Expect, value);
                            }
                            else
                            {
                                _bits |= 67108864L;
                                _Expect = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ((((pUI[0] & 3755991007u) == 1229017684u) && ((pUS[2] & 57311u) == 17740u) && ((pUB[6] & 223u) == 82u))) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                _Trailer = AppendValue(_Trailer, value);
                            }
                            else
                            {
                                _bits |= 32L;
                                _Trailer = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1380405333u) && ((pUS[2] & 57311u) == 17473u) && ((pUB[6] & 223u) == 69u))) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                _Upgrade = AppendValue(_Upgrade, value);
                            }
                            else
                            {
                                _bits |= 128L;
                                _Upgrade = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1314013527u) && ((pUS[2] & 57311u) == 20041u) && ((pUB[6] & 223u) == 71u))) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                _Warning = AppendValue(_Warning, value);
                            }
                            else
                            {
                                _bits |= 512L;
                                _Warning = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1230002245u) && ((pUS[2] & 57311u) == 17746u) && ((pUB[6] & 223u) == 83u))) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                _Expires = AppendValue(_Expires, value);
                            }
                            else
                            {
                                _bits |= 262144L;
                                _Expires = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1162233170u) && ((pUS[2] & 57311u) == 17746u) && ((pUB[6] & 223u) == 82u))) 
                        {
                            if (((_bits & 68719476736L) != 0))
                            {
                                _Referer = AppendValue(_Referer, value);
                            }
                            else
                            {
                                _bits |= 68719476736L;
                                _Referer = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 5928221808112259668uL) && ((pUL[1] & 16131858542891098111uL) == 5641115115480565037uL) && ((pUB[16] & 223u) == 71u))) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                _TransferEncoding = AppendValue(_TransferEncoding, value);
                            }
                            else
                            {
                                _bits |= 64L;
                                _TransferEncoding = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858542893195231uL) == 5064654363342751305uL) && ((pUL[1] & 16131858543427968991uL) == 4849894470315165001uL) && ((pUB[16] & 223u) == 69u))) 
                        {
                            if (((_bits & 1073741824L) != 0))
                            {
                                _IfModifiedSince = AppendValue(_IfModifiedSince, value);
                            }
                            else
                            {
                                _bits |= 1073741824L;
                                _IfModifiedSince = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ((((pUS[0] & 57311u) == 18774u) && ((pUB[2] & 223u) == 65u))) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                _Via = AppendValue(_Via, value);
                            }
                            else
                            {
                                _bits |= 256L;
                                _Via = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ((((pUI[0] & 3755991007u) == 1330400321u) && ((pUB[4] & 223u) == 87u))) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                _Allow = AppendValue(_Allow, value);
                            }
                            else
                            {
                                _bits |= 1024L;
                                _Allow = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1196310866u) && ((pUB[4] & 223u) == 69u))) 
                        {
                            if (((_bits & 137438953472L) != 0))
                            {
                                _Range = AppendValue(_Range, value);
                            }
                            else
                            {
                                _bits |= 137438953472L;
                                _Range = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1196311884u) && ((pUS[6] & 57311u) == 18516u))) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                _ContentLength = AppendValue(_ContentLength, value);
                            }
                            else
                            {
                                _bits |= 2048L;
                                _ContentLength = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16140865742145839071uL) == 4840617878229304129uL) && ((pUI[2] & 3755991007u) == 1397899592u) && ((pUS[6] & 57311u) == 21573u))) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                _AcceptCharset = AppendValue(_AcceptCharset, value);
                            }
                            else
                            {
                                _bits |= 2097152L;
                                _AcceptCharset = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1162893652u))) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                _ContentType = AppendValue(_ContentType, value);
                            }
                            else
                            {
                                _bits |= 4096L;
                                _ContentType = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858543427968991uL) == 6292178792217067853uL) && ((pUI[2] & 3755991007u) == 1396986433u))) 
                        {
                            if (((_bits & 17179869184L) != 0))
                            {
                                _MaxForwards = AppendValue(_MaxForwards, value);
                            }
                            else
                            {
                                _bits |= 17179869184L;
                                _MaxForwards = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 5138124782612729413uL))) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                _ContentEncoding = AppendValue(_ContentEncoding, value);
                            }
                            else
                            {
                                _bits |= 8192L;
                                _ContentEncoding = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 4992030546487820620uL))) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                _ContentLanguage = AppendValue(_ContentLanguage, value);
                            }
                            else
                            {
                                _bits |= 16384L;
                                _ContentLanguage = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 5642809484339531596uL))) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                _ContentLocation = AppendValue(_ContentLocation, value);
                            }
                            else
                            {
                                _bits |= 32768L;
                                _ContentLocation = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUS[4] & 57311u) == 17485u) && ((pUB[10] & 255u) == 53u))) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                _ContentMD5 = AppendValue(_ContentMD5, value);
                            }
                            else
                            {
                                _bits |= 65536L;
                                _ContentMD5 = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 15:
                    {
                        if ((((pUL[0] & 16140865742145839071uL) == 4984733066305160001uL) && ((pUI[2] & 3755991007u) == 1146045262u) && ((pUS[6] & 57311u) == 20041u) && ((pUB[14] & 223u) == 71u))) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                _AcceptEncoding = AppendValue(_AcceptEncoding, value);
                            }
                            else
                            {
                                _bits |= 4194304L;
                                _AcceptEncoding = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16140865742145839071uL) == 5489136224570655553uL) && ((pUI[2] & 3755991007u) == 1430736449u) && ((pUS[6] & 57311u) == 18241u) && ((pUB[14] & 223u) == 69u))) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                _AcceptLanguage = AppendValue(_AcceptLanguage, value);
                            }
                            else
                            {
                                _bits |= 8388608L;
                                _AcceptLanguage = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ((((pUL[0] & 16131858542893195231uL) == 5207098233614845513uL))) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                _IfMatch = AppendValue(_IfMatch, value);
                            }
                            else
                            {
                                _bits |= 536870912L;
                                _IfMatch = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858542893195231uL) == 4992044754422023753uL))) 
                        {
                            if (((_bits & 4294967296L) != 0))
                            {
                                _IfRange = AppendValue(_IfRange, value);
                            }
                            else
                            {
                                _bits |= 4294967296L;
                                _IfRange = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 19:
                    {
                        if ((((pUL[0] & 16131858542893195231uL) == 4922237916571059785uL) && ((pUL[1] & 16131893727263186911uL) == 5283616559079179849uL) && ((pUS[8] & 57311u) == 17230u) && ((pUB[18] & 223u) == 69u))) 
                        {
                            if (((_bits & 8589934592L) != 0))
                            {
                                _IfUnmodifiedSince = AppendValue(_IfUnmodifiedSince, value);
                            }
                            else
                            {
                                _bits |= 8589934592L;
                                _IfUnmodifiedSince = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131893727263186911uL) == 6143241228466999888uL) && ((pUL[1] & 16131858542891098079uL) == 6071233043632179284uL) && ((pUS[8] & 57311u) == 20297u) && ((pUB[18] & 223u) == 78u))) 
                        {
                            if (((_bits & 34359738368L) != 0))
                            {
                                _ProxyAuthorization = AppendValue(_ProxyAuthorization, value);
                            }
                            else
                            {
                                _bits |= 34359738368L;
                                _ProxyAuthorization = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 2:
                    {
                        if ((((pUS[0] & 57311u) == 17748u))) 
                        {
                            if (((_bits & 274877906944L) != 0))
                            {
                                _TE = AppendValue(_TE, value);
                            }
                            else
                            {
                                _bits |= 274877906944L;
                                _TE = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 9:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 6071217693351039572uL) && ((pUB[8] & 223u) == 69u))) 
                        {
                            if (((_bits & 549755813888L) != 0))
                            {
                                _Translate = AppendValue(_Translate, value);
                            }
                            else
                            {
                                _bits |= 549755813888L;
                                _Translate = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            }}
            var key = System.Text.Encoding.ASCII.GetString(keyBytes, keyOffset, keyLength);
            string[] existing;
            Unknown[key] = Unknown.TryGetValue(key, out existing) ? AppendValue(existing, value) : new[] {value};
        }

        public partial struct Enumerator
        {
            public bool MoveNext()
            {
                switch (_state)
                {
                    
                        case 0:
                            goto state0;
                    
                        case 1:
                            goto state1;
                    
                        case 2:
                            goto state2;
                    
                        case 3:
                            goto state3;
                    
                        case 4:
                            goto state4;
                    
                        case 5:
                            goto state5;
                    
                        case 6:
                            goto state6;
                    
                        case 7:
                            goto state7;
                    
                        case 8:
                            goto state8;
                    
                        case 9:
                            goto state9;
                    
                        case 10:
                            goto state10;
                    
                        case 11:
                            goto state11;
                    
                        case 12:
                            goto state12;
                    
                        case 13:
                            goto state13;
                    
                        case 14:
                            goto state14;
                    
                        case 15:
                            goto state15;
                    
                        case 16:
                            goto state16;
                    
                        case 17:
                            goto state17;
                    
                        case 18:
                            goto state18;
                    
                        case 19:
                            goto state19;
                    
                        case 20:
                            goto state20;
                    
                        case 21:
                            goto state21;
                    
                        case 22:
                            goto state22;
                    
                        case 23:
                            goto state23;
                    
                        case 24:
                            goto state24;
                    
                        case 25:
                            goto state25;
                    
                        case 26:
                            goto state26;
                    
                        case 27:
                            goto state27;
                    
                        case 28:
                            goto state28;
                    
                        case 29:
                            goto state29;
                    
                        case 30:
                            goto state30;
                    
                        case 31:
                            goto state31;
                    
                        case 32:
                            goto state32;
                    
                        case 33:
                            goto state33;
                    
                        case 34:
                            goto state34;
                    
                        case 35:
                            goto state35;
                    
                        case 36:
                            goto state36;
                    
                        case 37:
                            goto state37;
                    
                        case 38:
                            goto state38;
                    
                        case 39:
                            goto state39;
                    
                        case 40:
                            goto state40;
                    
                    default:
                        goto state_default;
                }
                
                state0:
                    if (((_bits & 1L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Cache-Control", _collection._CacheControl);
                        _state = 1;
                        return true;
                    }
                
                state1:
                    if (((_bits & 2L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Connection", _collection._Connection);
                        _state = 2;
                        return true;
                    }
                
                state2:
                    if (((_bits & 4L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Date", _collection._Date);
                        _state = 3;
                        return true;
                    }
                
                state3:
                    if (((_bits & 8L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Keep-Alive", _collection._KeepAlive);
                        _state = 4;
                        return true;
                    }
                
                state4:
                    if (((_bits & 16L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Pragma", _collection._Pragma);
                        _state = 5;
                        return true;
                    }
                
                state5:
                    if (((_bits & 32L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Trailer", _collection._Trailer);
                        _state = 6;
                        return true;
                    }
                
                state6:
                    if (((_bits & 64L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Transfer-Encoding", _collection._TransferEncoding);
                        _state = 7;
                        return true;
                    }
                
                state7:
                    if (((_bits & 128L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Upgrade", _collection._Upgrade);
                        _state = 8;
                        return true;
                    }
                
                state8:
                    if (((_bits & 256L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Via", _collection._Via);
                        _state = 9;
                        return true;
                    }
                
                state9:
                    if (((_bits & 512L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Warning", _collection._Warning);
                        _state = 10;
                        return true;
                    }
                
                state10:
                    if (((_bits & 1024L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Allow", _collection._Allow);
                        _state = 11;
                        return true;
                    }
                
                state11:
                    if (((_bits & 2048L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Length", _collection._ContentLength);
                        _state = 12;
                        return true;
                    }
                
                state12:
                    if (((_bits & 4096L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Type", _collection._ContentType);
                        _state = 13;
                        return true;
                    }
                
                state13:
                    if (((_bits & 8192L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Encoding", _collection._ContentEncoding);
                        _state = 14;
                        return true;
                    }
                
                state14:
                    if (((_bits & 16384L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Language", _collection._ContentLanguage);
                        _state = 15;
                        return true;
                    }
                
                state15:
                    if (((_bits & 32768L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Location", _collection._ContentLocation);
                        _state = 16;
                        return true;
                    }
                
                state16:
                    if (((_bits & 65536L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-MD5", _collection._ContentMD5);
                        _state = 17;
                        return true;
                    }
                
                state17:
                    if (((_bits & 131072L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Range", _collection._ContentRange);
                        _state = 18;
                        return true;
                    }
                
                state18:
                    if (((_bits & 262144L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Expires", _collection._Expires);
                        _state = 19;
                        return true;
                    }
                
                state19:
                    if (((_bits & 524288L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Last-Modified", _collection._LastModified);
                        _state = 20;
                        return true;
                    }
                
                state20:
                    if (((_bits & 1048576L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Accept", _collection._Accept);
                        _state = 21;
                        return true;
                    }
                
                state21:
                    if (((_bits & 2097152L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Accept-Charset", _collection._AcceptCharset);
                        _state = 22;
                        return true;
                    }
                
                state22:
                    if (((_bits & 4194304L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Accept-Encoding", _collection._AcceptEncoding);
                        _state = 23;
                        return true;
                    }
                
                state23:
                    if (((_bits & 8388608L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Accept-Language", _collection._AcceptLanguage);
                        _state = 24;
                        return true;
                    }
                
                state24:
                    if (((_bits & 16777216L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Authorization", _collection._Authorization);
                        _state = 25;
                        return true;
                    }
                
                state25:
                    if (((_bits & 33554432L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Cookie", _collection._Cookie);
                        _state = 26;
                        return true;
                    }
                
                state26:
                    if (((_bits & 67108864L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Expect", _collection._Expect);
                        _state = 27;
                        return true;
                    }
                
                state27:
                    if (((_bits & 134217728L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("From", _collection._From);
                        _state = 28;
                        return true;
                    }
                
                state28:
                    if (((_bits & 268435456L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Host", _collection._Host);
                        _state = 29;
                        return true;
                    }
                
                state29:
                    if (((_bits & 536870912L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("If-Match", _collection._IfMatch);
                        _state = 30;
                        return true;
                    }
                
                state30:
                    if (((_bits & 1073741824L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("If-Modified-Since", _collection._IfModifiedSince);
                        _state = 31;
                        return true;
                    }
                
                state31:
                    if (((_bits & 2147483648L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("If-None-Match", _collection._IfNoneMatch);
                        _state = 32;
                        return true;
                    }
                
                state32:
                    if (((_bits & 4294967296L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("If-Range", _collection._IfRange);
                        _state = 33;
                        return true;
                    }
                
                state33:
                    if (((_bits & 8589934592L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("If-Unmodified-Since", _collection._IfUnmodifiedSince);
                        _state = 34;
                        return true;
                    }
                
                state34:
                    if (((_bits & 17179869184L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Max-Forwards", _collection._MaxForwards);
                        _state = 35;
                        return true;
                    }
                
                state35:
                    if (((_bits & 34359738368L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Proxy-Authorization", _collection._ProxyAuthorization);
                        _state = 36;
                        return true;
                    }
                
                state36:
                    if (((_bits & 68719476736L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Referer", _collection._Referer);
                        _state = 37;
                        return true;
                    }
                
                state37:
                    if (((_bits & 137438953472L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Range", _collection._Range);
                        _state = 38;
                        return true;
                    }
                
                state38:
                    if (((_bits & 274877906944L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("TE", _collection._TE);
                        _state = 39;
                        return true;
                    }
                
                state39:
                    if (((_bits & 549755813888L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Translate", _collection._Translate);
                        _state = 40;
                        return true;
                    }
                
                state40:
                    if (((_bits & 1099511627776L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("User-Agent", _collection._UserAgent);
                        _state = 41;
                        return true;
                    }
                
                state_default:
                    if (!_hasUnknown || !_unknownEnumerator.MoveNext())
                    {
                        _current = default(KeyValuePair<string, string[]>);
                        return false;
                    }
                    _current = _unknownEnumerator.Current;
                    return true;
            }
        }
    }

    public partial class FrameResponseHeaders 
    {
        long _bits = 0;
        
        string[] _CacheControl;
        string[] _Connection;
        string[] _Date;
        string[] _KeepAlive;
        string[] _Pragma;
        string[] _Trailer;
        string[] _TransferEncoding;
        string[] _Upgrade;
        string[] _Via;
        string[] _Warning;
        string[] _Allow;
        string[] _ContentLength;
        string[] _ContentType;
        string[] _ContentEncoding;
        string[] _ContentLanguage;
        string[] _ContentLocation;
        string[] _ContentMD5;
        string[] _ContentRange;
        string[] _Expires;
        string[] _LastModified;
        string[] _AcceptRanges;
        string[] _Age;
        string[] _ETag;
        string[] _Location;
        string[] _ProxyAutheticate;
        string[] _RetryAfter;
        string[] _Server;
        string[] _SetCookie;
        string[] _Vary;
        string[] _WWWAuthenticate;

        protected override int GetCountFast()
        {
            var count = MaybeUnknown?.Count ?? 0;
            
                if (((_bits & 1L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 32L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 64L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 128L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 256L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 512L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1024L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2048L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4096L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8192L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16384L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 32768L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 65536L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 131072L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 262144L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 524288L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 1048576L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 2097152L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 4194304L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 8388608L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 16777216L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 33554432L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 67108864L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 134217728L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 268435456L) != 0)) 
                {
                    ++count;
                }
            
                if (((_bits & 536870912L) != 0)) 
                {
                    ++count;
                }
            
            return count;
        }

        protected override string[] GetValueFast(string key)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                return _CacheControl;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                return _ContentRange;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                return _LastModified;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Accept-Ranges".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                return _AcceptRanges;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                return _Connection;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                return _KeepAlive;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Set-Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                return _SetCookie;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                return _Date;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("ETag".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                return _ETag;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Vary".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                return _Vary;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                return _Pragma;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Server".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                return _Server;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                return _Trailer;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                return _Upgrade;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                return _Warning;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                return _Expires;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                return _TransferEncoding;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Proxy-Autheticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                return _ProxyAutheticate;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                return _Via;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Age".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                return _Age;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                return _Allow;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                return _ContentLength;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                return _ContentType;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                return _ContentEncoding;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                return _ContentLanguage;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                return _ContentLocation;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("WWW-Authenticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                return _WWWAuthenticate;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                return _ContentMD5;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    
                        if ("Retry-After".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                return _RetryAfter;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                return _Location;
                            }
                            else
                            {
                                throw new System.Collections.Generic.KeyNotFoundException();
                            }
                        }
                    }
                    break;
            }
            if (MaybeUnknown == null) 
            {
                throw new System.Collections.Generic.KeyNotFoundException();
            }
            return MaybeUnknown[key];
        }

        protected override bool TryGetValueFast(string key, out string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                value = _CacheControl;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                value = _ContentRange;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                value = _LastModified;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Accept-Ranges".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                value = _AcceptRanges;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                value = _Connection;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                value = _KeepAlive;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Set-Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                value = _SetCookie;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                value = _Date;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("ETag".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                value = _ETag;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Vary".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                value = _Vary;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                value = _Pragma;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Server".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                value = _Server;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                value = _Trailer;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                value = _Upgrade;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                value = _Warning;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                value = _Expires;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                value = _TransferEncoding;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Proxy-Autheticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                value = _ProxyAutheticate;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                value = _Via;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Age".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                value = _Age;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                value = _Allow;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                value = _ContentLength;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                value = _ContentType;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                value = _ContentEncoding;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                value = _ContentLanguage;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                value = _ContentLocation;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("WWW-Authenticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                value = _WWWAuthenticate;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                value = _ContentMD5;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    
                        if ("Retry-After".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                value = _RetryAfter;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                value = _Location;
                                return true;
                            }
                            else
                            {
                                value = null;
                                return false;
                            }
                        }
                    }
                    break;
            }
            value = null;
            return MaybeUnknown?.TryGetValue(key, out value) ?? false;
        }

        protected override void SetValueFast(string key, string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1L;
                            _CacheControl = value;
                            return;
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 131072L;
                            _ContentRange = value;
                            return;
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 524288L;
                            _LastModified = value;
                            return;
                        }
                    
                        if ("Accept-Ranges".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1048576L;
                            _AcceptRanges = value;
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2L;
                            _Connection = value;
                            return;
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8L;
                            _KeepAlive = value;
                            return;
                        }
                    
                        if ("Set-Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 134217728L;
                            _SetCookie = value;
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4L;
                            _Date = value;
                            return;
                        }
                    
                        if ("ETag".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4194304L;
                            _ETag = value;
                            return;
                        }
                    
                        if ("Vary".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 268435456L;
                            _Vary = value;
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16L;
                            _Pragma = value;
                            return;
                        }
                    
                        if ("Server".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 67108864L;
                            _Server = value;
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 32L;
                            _Trailer = value;
                            return;
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 128L;
                            _Upgrade = value;
                            return;
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 512L;
                            _Warning = value;
                            return;
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 262144L;
                            _Expires = value;
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 64L;
                            _TransferEncoding = value;
                            return;
                        }
                    
                        if ("Proxy-Autheticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16777216L;
                            _ProxyAutheticate = value;
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 256L;
                            _Via = value;
                            return;
                        }
                    
                        if ("Age".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2097152L;
                            _Age = value;
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 1024L;
                            _Allow = value;
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 2048L;
                            _ContentLength = value;
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 4096L;
                            _ContentType = value;
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8192L;
                            _ContentEncoding = value;
                            return;
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 16384L;
                            _ContentLanguage = value;
                            return;
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 32768L;
                            _ContentLocation = value;
                            return;
                        }
                    
                        if ("WWW-Authenticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 536870912L;
                            _WWWAuthenticate = value;
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 65536L;
                            _ContentMD5 = value;
                            return;
                        }
                    
                        if ("Retry-After".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 33554432L;
                            _RetryAfter = value;
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            _bits |= 8388608L;
                            _Location = value;
                            return;
                        }
                    }
                    break;
            }
            Unknown[key] = value;
        }

        protected override void AddValueFast(string key, string[] value)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1L;
                            _CacheControl = value;
                            return;
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 131072L;
                            _ContentRange = value;
                            return;
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 524288L;
                            _LastModified = value;
                            return;
                        }
                    
                        if ("Accept-Ranges".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1048576L;
                            _AcceptRanges = value;
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2L;
                            _Connection = value;
                            return;
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8L;
                            _KeepAlive = value;
                            return;
                        }
                    
                        if ("Set-Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 134217728L;
                            _SetCookie = value;
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4L;
                            _Date = value;
                            return;
                        }
                    
                        if ("ETag".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4194304L;
                            _ETag = value;
                            return;
                        }
                    
                        if ("Vary".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 268435456L;
                            _Vary = value;
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16L;
                            _Pragma = value;
                            return;
                        }
                    
                        if ("Server".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 67108864L;
                            _Server = value;
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 32L;
                            _Trailer = value;
                            return;
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 128L;
                            _Upgrade = value;
                            return;
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 512L;
                            _Warning = value;
                            return;
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 262144L;
                            _Expires = value;
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 64L;
                            _TransferEncoding = value;
                            return;
                        }
                    
                        if ("Proxy-Autheticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16777216L;
                            _ProxyAutheticate = value;
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 256L;
                            _Via = value;
                            return;
                        }
                    
                        if ("Age".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2097152L;
                            _Age = value;
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 1024L;
                            _Allow = value;
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 2048L;
                            _ContentLength = value;
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 4096L;
                            _ContentType = value;
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8192L;
                            _ContentEncoding = value;
                            return;
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 16384L;
                            _ContentLanguage = value;
                            return;
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 32768L;
                            _ContentLocation = value;
                            return;
                        }
                    
                        if ("WWW-Authenticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 536870912L;
                            _WWWAuthenticate = value;
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 65536L;
                            _ContentMD5 = value;
                            return;
                        }
                    
                        if ("Retry-After".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 33554432L;
                            _RetryAfter = value;
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                throw new ArgumentException("An item with the same key has already been added.");
                            }
                            _bits |= 8388608L;
                            _Location = value;
                            return;
                        }
                    }
                    break;
            }
            Unknown.Add(key, value);
        }

        protected override bool RemoveFast(string key)
        {
            switch(key.Length)
            {
                case 13:
                    {
                        if ("Cache-Control".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                _bits &= ~1L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Range".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                _bits &= ~131072L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Last-Modified".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                _bits &= ~524288L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Accept-Ranges".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                _bits &= ~1048576L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ("Connection".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                _bits &= ~2L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Keep-Alive".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                _bits &= ~8L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Set-Cookie".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                _bits &= ~134217728L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ("Date".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                _bits &= ~4L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("ETag".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                _bits &= ~4194304L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Vary".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                _bits &= ~268435456L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ("Pragma".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                _bits &= ~16L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Server".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                _bits &= ~67108864L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ("Trailer".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                _bits &= ~32L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Upgrade".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                _bits &= ~128L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Warning".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                _bits &= ~512L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Expires".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                _bits &= ~262144L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ("Transfer-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                _bits &= ~64L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Proxy-Autheticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                _bits &= ~16777216L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ("Via".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                _bits &= ~256L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Age".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                _bits &= ~2097152L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ("Allow".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                _bits &= ~1024L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ("Content-Length".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                _bits &= ~2048L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ("Content-Type".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                _bits &= ~4096L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ("Content-Encoding".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                _bits &= ~8192L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Language".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                _bits &= ~16384L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Content-Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                _bits &= ~32768L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("WWW-Authenticate".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                _bits &= ~536870912L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ("Content-MD5".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                _bits &= ~65536L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    
                        if ("Retry-After".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                _bits &= ~33554432L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ("Location".Equals(key, StringComparison.OrdinalIgnoreCase)) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                _bits &= ~8388608L;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    break;
            }
            return MaybeUnknown?.Remove(key) ?? false;
        }

        protected override void ClearFast()
        {
            _bits = 0;
            MaybeUnknown?.Clear();
        }
        
        protected override void CopyToFast(KeyValuePair<string, string[]>[] array, int arrayIndex)
        {
            if (arrayIndex < 0)
            {
                throw new ArgumentException();
            }

            
                if (((_bits & 1L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Cache-Control", _CacheControl);
                    ++arrayIndex;
                }
            
                if (((_bits & 2L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Connection", _Connection);
                    ++arrayIndex;
                }
            
                if (((_bits & 4L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Date", _Date);
                    ++arrayIndex;
                }
            
                if (((_bits & 8L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Keep-Alive", _KeepAlive);
                    ++arrayIndex;
                }
            
                if (((_bits & 16L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Pragma", _Pragma);
                    ++arrayIndex;
                }
            
                if (((_bits & 32L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Trailer", _Trailer);
                    ++arrayIndex;
                }
            
                if (((_bits & 64L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Transfer-Encoding", _TransferEncoding);
                    ++arrayIndex;
                }
            
                if (((_bits & 128L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Upgrade", _Upgrade);
                    ++arrayIndex;
                }
            
                if (((_bits & 256L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Via", _Via);
                    ++arrayIndex;
                }
            
                if (((_bits & 512L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Warning", _Warning);
                    ++arrayIndex;
                }
            
                if (((_bits & 1024L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Allow", _Allow);
                    ++arrayIndex;
                }
            
                if (((_bits & 2048L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Length", _ContentLength);
                    ++arrayIndex;
                }
            
                if (((_bits & 4096L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Type", _ContentType);
                    ++arrayIndex;
                }
            
                if (((_bits & 8192L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Encoding", _ContentEncoding);
                    ++arrayIndex;
                }
            
                if (((_bits & 16384L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Language", _ContentLanguage);
                    ++arrayIndex;
                }
            
                if (((_bits & 32768L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Location", _ContentLocation);
                    ++arrayIndex;
                }
            
                if (((_bits & 65536L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-MD5", _ContentMD5);
                    ++arrayIndex;
                }
            
                if (((_bits & 131072L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Content-Range", _ContentRange);
                    ++arrayIndex;
                }
            
                if (((_bits & 262144L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Expires", _Expires);
                    ++arrayIndex;
                }
            
                if (((_bits & 524288L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Last-Modified", _LastModified);
                    ++arrayIndex;
                }
            
                if (((_bits & 1048576L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Accept-Ranges", _AcceptRanges);
                    ++arrayIndex;
                }
            
                if (((_bits & 2097152L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Age", _Age);
                    ++arrayIndex;
                }
            
                if (((_bits & 4194304L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("ETag", _ETag);
                    ++arrayIndex;
                }
            
                if (((_bits & 8388608L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Location", _Location);
                    ++arrayIndex;
                }
            
                if (((_bits & 16777216L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Proxy-Autheticate", _ProxyAutheticate);
                    ++arrayIndex;
                }
            
                if (((_bits & 33554432L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Retry-After", _RetryAfter);
                    ++arrayIndex;
                }
            
                if (((_bits & 67108864L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Server", _Server);
                    ++arrayIndex;
                }
            
                if (((_bits & 134217728L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Set-Cookie", _SetCookie);
                    ++arrayIndex;
                }
            
                if (((_bits & 268435456L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("Vary", _Vary);
                    ++arrayIndex;
                }
            
                if (((_bits & 536870912L) != 0)) 
                {
                    if (arrayIndex == array.Length)
                    {
                        throw new ArgumentException();
                    }

                    array[arrayIndex] = new KeyValuePair<string, string[]>("WWW-Authenticate", _WWWAuthenticate);
                    ++arrayIndex;
                }
            
            ((ICollection<KeyValuePair<string, string[]>>)MaybeUnknown)?.CopyTo(array, arrayIndex);
        }

        public unsafe void Append(byte[] keyBytes, int keyOffset, int keyLength, string value)
        {
            fixed(byte* ptr = keyBytes) { var pUB = ptr + keyOffset; var pUL = (ulong*)pUB; var pUI = (uint*)pUB; var pUS = (ushort*)pUB;
            switch(keyLength)
            {
                case 13:
                    {
                        if ((((pUL[0] & 16131893727263186911uL) == 5711458528024281411uL) && ((pUI[2] & 3755991007u) == 1330795598u) && ((pUB[12] & 223u) == 76u))) 
                        {
                            if (((_bits & 1L) != 0))
                            {
                                _CacheControl = AppendValue(_CacheControl, value);
                            }
                            else
                            {
                                _bits |= 1L;
                                _CacheControl = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1196310866u) && ((pUB[12] & 223u) == 69u))) 
                        {
                            if (((_bits & 131072L) != 0))
                            {
                                _ContentRange = AppendValue(_ContentRange, value);
                            }
                            else
                            {
                                _bits |= 131072L;
                                _ContentRange = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858680330051551uL) == 4922237774822850892uL) && ((pUI[2] & 3755991007u) == 1162430025u) && ((pUB[12] & 223u) == 68u))) 
                        {
                            if (((_bits & 524288L) != 0))
                            {
                                _LastModified = AppendValue(_LastModified, value);
                            }
                            else
                            {
                                _bits |= 524288L;
                                _LastModified = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16140865742145839071uL) == 5921481788798223169uL) && ((pUI[2] & 3755991007u) == 1162300993u) && ((pUB[12] & 223u) == 83u))) 
                        {
                            if (((_bits & 1048576L) != 0))
                            {
                                _AcceptRanges = AppendValue(_AcceptRanges, value);
                            }
                            else
                            {
                                _bits |= 1048576L;
                                _AcceptRanges = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 10:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 5283922227757993795uL) && ((pUS[4] & 57311u) == 20047u))) 
                        {
                            if (((_bits & 2L) != 0))
                            {
                                _Connection = AppendValue(_Connection, value);
                            }
                            else
                            {
                                _bits |= 2L;
                                _Connection = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858680330051551uL) == 5281668125874799947uL) && ((pUS[4] & 57311u) == 17750u))) 
                        {
                            if (((_bits & 8L) != 0))
                            {
                                _KeepAlive = AppendValue(_KeepAlive, value);
                            }
                            else
                            {
                                _bits |= 8L;
                                _KeepAlive = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858543427968991uL) == 5426643225946637651uL) && ((pUS[4] & 57311u) == 17737u))) 
                        {
                            if (((_bits & 134217728L) != 0))
                            {
                                _SetCookie = AppendValue(_SetCookie, value);
                            }
                            else
                            {
                                _bits |= 134217728L;
                                _SetCookie = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 4:
                    {
                        if ((((pUI[0] & 3755991007u) == 1163149636u))) 
                        {
                            if (((_bits & 4L) != 0))
                            {
                                _Date = AppendValue(_Date, value);
                            }
                            else
                            {
                                _bits |= 4L;
                                _Date = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1195463749u))) 
                        {
                            if (((_bits & 4194304L) != 0))
                            {
                                _ETag = AppendValue(_ETag, value);
                            }
                            else
                            {
                                _bits |= 4194304L;
                                _ETag = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1498562902u))) 
                        {
                            if (((_bits & 268435456L) != 0))
                            {
                                _Vary = AppendValue(_Vary, value);
                            }
                            else
                            {
                                _bits |= 268435456L;
                                _Vary = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 6:
                    {
                        if ((((pUI[0] & 3755991007u) == 1195463248u) && ((pUS[2] & 57311u) == 16717u))) 
                        {
                            if (((_bits & 16L) != 0))
                            {
                                _Pragma = AppendValue(_Pragma, value);
                            }
                            else
                            {
                                _bits |= 16L;
                                _Pragma = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1448232275u) && ((pUS[2] & 57311u) == 21061u))) 
                        {
                            if (((_bits & 67108864L) != 0))
                            {
                                _Server = AppendValue(_Server, value);
                            }
                            else
                            {
                                _bits |= 67108864L;
                                _Server = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 7:
                    {
                        if ((((pUI[0] & 3755991007u) == 1229017684u) && ((pUS[2] & 57311u) == 17740u) && ((pUB[6] & 223u) == 82u))) 
                        {
                            if (((_bits & 32L) != 0))
                            {
                                _Trailer = AppendValue(_Trailer, value);
                            }
                            else
                            {
                                _bits |= 32L;
                                _Trailer = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1380405333u) && ((pUS[2] & 57311u) == 17473u) && ((pUB[6] & 223u) == 69u))) 
                        {
                            if (((_bits & 128L) != 0))
                            {
                                _Upgrade = AppendValue(_Upgrade, value);
                            }
                            else
                            {
                                _bits |= 128L;
                                _Upgrade = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1314013527u) && ((pUS[2] & 57311u) == 20041u) && ((pUB[6] & 223u) == 71u))) 
                        {
                            if (((_bits & 512L) != 0))
                            {
                                _Warning = AppendValue(_Warning, value);
                            }
                            else
                            {
                                _bits |= 512L;
                                _Warning = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUI[0] & 3755991007u) == 1230002245u) && ((pUS[2] & 57311u) == 17746u) && ((pUB[6] & 223u) == 83u))) 
                        {
                            if (((_bits & 262144L) != 0))
                            {
                                _Expires = AppendValue(_Expires, value);
                            }
                            else
                            {
                                _bits |= 262144L;
                                _Expires = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 17:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 5928221808112259668uL) && ((pUL[1] & 16131858542891098111uL) == 5641115115480565037uL) && ((pUB[16] & 223u) == 71u))) 
                        {
                            if (((_bits & 64L) != 0))
                            {
                                _TransferEncoding = AppendValue(_TransferEncoding, value);
                            }
                            else
                            {
                                _bits |= 64L;
                                _TransferEncoding = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131893727263186911uL) == 6143241228466999888uL) && ((pUL[1] & 16131858542891098079uL) == 6071207754897639508uL) && ((pUB[16] & 223u) == 69u))) 
                        {
                            if (((_bits & 16777216L) != 0))
                            {
                                _ProxyAutheticate = AppendValue(_ProxyAutheticate, value);
                            }
                            else
                            {
                                _bits |= 16777216L;
                                _ProxyAutheticate = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 3:
                    {
                        if ((((pUS[0] & 57311u) == 18774u) && ((pUB[2] & 223u) == 65u))) 
                        {
                            if (((_bits & 256L) != 0))
                            {
                                _Via = AppendValue(_Via, value);
                            }
                            else
                            {
                                _bits |= 256L;
                                _Via = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUS[0] & 57311u) == 18241u) && ((pUB[2] & 223u) == 69u))) 
                        {
                            if (((_bits & 2097152L) != 0))
                            {
                                _Age = AppendValue(_Age, value);
                            }
                            else
                            {
                                _bits |= 2097152L;
                                _Age = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 5:
                    {
                        if ((((pUI[0] & 3755991007u) == 1330400321u) && ((pUB[4] & 223u) == 87u))) 
                        {
                            if (((_bits & 1024L) != 0))
                            {
                                _Allow = AppendValue(_Allow, value);
                            }
                            else
                            {
                                _bits |= 1024L;
                                _Allow = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 14:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1196311884u) && ((pUS[6] & 57311u) == 18516u))) 
                        {
                            if (((_bits & 2048L) != 0))
                            {
                                _ContentLength = AppendValue(_ContentLength, value);
                            }
                            else
                            {
                                _bits |= 2048L;
                                _ContentLength = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 12:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUI[2] & 3755991007u) == 1162893652u))) 
                        {
                            if (((_bits & 4096L) != 0))
                            {
                                _ContentType = AppendValue(_ContentType, value);
                            }
                            else
                            {
                                _bits |= 4096L;
                                _ContentType = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 16:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 5138124782612729413uL))) 
                        {
                            if (((_bits & 8192L) != 0))
                            {
                                _ContentEncoding = AppendValue(_ContentEncoding, value);
                            }
                            else
                            {
                                _bits |= 8192L;
                                _ContentEncoding = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 4992030546487820620uL))) 
                        {
                            if (((_bits & 16384L) != 0))
                            {
                                _ContentLanguage = AppendValue(_ContentLanguage, value);
                            }
                            else
                            {
                                _bits |= 16384L;
                                _ContentLanguage = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUL[1] & 16131858542891098079uL) == 5642809484339531596uL))) 
                        {
                            if (((_bits & 32768L) != 0))
                            {
                                _ContentLocation = AppendValue(_ContentLocation, value);
                            }
                            else
                            {
                                _bits |= 32768L;
                                _ContentLocation = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131858543427968991uL) == 5211884407196440407uL) && ((pUL[1] & 16131858542891098079uL) == 4995689643909598789uL))) 
                        {
                            if (((_bits & 536870912L) != 0))
                            {
                                _WWWAuthenticate = AppendValue(_WWWAuthenticate, value);
                            }
                            else
                            {
                                _bits |= 536870912L;
                                _WWWAuthenticate = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 11:
                    {
                        if ((((pUL[0] & 18437701552104792031uL) == 3266321689424580419uL) && ((pUS[4] & 57311u) == 17485u) && ((pUB[10] & 255u) == 53u))) 
                        {
                            if (((_bits & 65536L) != 0))
                            {
                                _ContentMD5 = AppendValue(_ContentMD5, value);
                            }
                            else
                            {
                                _bits |= 65536L;
                                _ContentMD5 = new[] {value};
                            }
                            return;
                        }
                    
                        if ((((pUL[0] & 16131893727263186911uL) == 5062377317797741906uL) && ((pUS[4] & 57311u) == 17748u) && ((pUB[10] & 223u) == 82u))) 
                        {
                            if (((_bits & 33554432L) != 0))
                            {
                                _RetryAfter = AppendValue(_RetryAfter, value);
                            }
                            else
                            {
                                _bits |= 33554432L;
                                _RetryAfter = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            
                case 8:
                    {
                        if ((((pUL[0] & 16131858542891098079uL) == 5642809484339531596uL))) 
                        {
                            if (((_bits & 8388608L) != 0))
                            {
                                _Location = AppendValue(_Location, value);
                            }
                            else
                            {
                                _bits |= 8388608L;
                                _Location = new[] {value};
                            }
                            return;
                        }
                    }
                    break;
            }}
            var key = System.Text.Encoding.ASCII.GetString(keyBytes, keyOffset, keyLength);
            string[] existing;
            Unknown[key] = Unknown.TryGetValue(key, out existing) ? AppendValue(existing, value) : new[] {value};
        }

        public partial struct Enumerator
        {
            public bool MoveNext()
            {
                switch (_state)
                {
                    
                        case 0:
                            goto state0;
                    
                        case 1:
                            goto state1;
                    
                        case 2:
                            goto state2;
                    
                        case 3:
                            goto state3;
                    
                        case 4:
                            goto state4;
                    
                        case 5:
                            goto state5;
                    
                        case 6:
                            goto state6;
                    
                        case 7:
                            goto state7;
                    
                        case 8:
                            goto state8;
                    
                        case 9:
                            goto state9;
                    
                        case 10:
                            goto state10;
                    
                        case 11:
                            goto state11;
                    
                        case 12:
                            goto state12;
                    
                        case 13:
                            goto state13;
                    
                        case 14:
                            goto state14;
                    
                        case 15:
                            goto state15;
                    
                        case 16:
                            goto state16;
                    
                        case 17:
                            goto state17;
                    
                        case 18:
                            goto state18;
                    
                        case 19:
                            goto state19;
                    
                        case 20:
                            goto state20;
                    
                        case 21:
                            goto state21;
                    
                        case 22:
                            goto state22;
                    
                        case 23:
                            goto state23;
                    
                        case 24:
                            goto state24;
                    
                        case 25:
                            goto state25;
                    
                        case 26:
                            goto state26;
                    
                        case 27:
                            goto state27;
                    
                        case 28:
                            goto state28;
                    
                        case 29:
                            goto state29;
                    
                    default:
                        goto state_default;
                }
                
                state0:
                    if (((_bits & 1L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Cache-Control", _collection._CacheControl);
                        _state = 1;
                        return true;
                    }
                
                state1:
                    if (((_bits & 2L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Connection", _collection._Connection);
                        _state = 2;
                        return true;
                    }
                
                state2:
                    if (((_bits & 4L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Date", _collection._Date);
                        _state = 3;
                        return true;
                    }
                
                state3:
                    if (((_bits & 8L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Keep-Alive", _collection._KeepAlive);
                        _state = 4;
                        return true;
                    }
                
                state4:
                    if (((_bits & 16L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Pragma", _collection._Pragma);
                        _state = 5;
                        return true;
                    }
                
                state5:
                    if (((_bits & 32L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Trailer", _collection._Trailer);
                        _state = 6;
                        return true;
                    }
                
                state6:
                    if (((_bits & 64L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Transfer-Encoding", _collection._TransferEncoding);
                        _state = 7;
                        return true;
                    }
                
                state7:
                    if (((_bits & 128L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Upgrade", _collection._Upgrade);
                        _state = 8;
                        return true;
                    }
                
                state8:
                    if (((_bits & 256L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Via", _collection._Via);
                        _state = 9;
                        return true;
                    }
                
                state9:
                    if (((_bits & 512L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Warning", _collection._Warning);
                        _state = 10;
                        return true;
                    }
                
                state10:
                    if (((_bits & 1024L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Allow", _collection._Allow);
                        _state = 11;
                        return true;
                    }
                
                state11:
                    if (((_bits & 2048L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Length", _collection._ContentLength);
                        _state = 12;
                        return true;
                    }
                
                state12:
                    if (((_bits & 4096L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Type", _collection._ContentType);
                        _state = 13;
                        return true;
                    }
                
                state13:
                    if (((_bits & 8192L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Encoding", _collection._ContentEncoding);
                        _state = 14;
                        return true;
                    }
                
                state14:
                    if (((_bits & 16384L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Language", _collection._ContentLanguage);
                        _state = 15;
                        return true;
                    }
                
                state15:
                    if (((_bits & 32768L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Location", _collection._ContentLocation);
                        _state = 16;
                        return true;
                    }
                
                state16:
                    if (((_bits & 65536L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-MD5", _collection._ContentMD5);
                        _state = 17;
                        return true;
                    }
                
                state17:
                    if (((_bits & 131072L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Content-Range", _collection._ContentRange);
                        _state = 18;
                        return true;
                    }
                
                state18:
                    if (((_bits & 262144L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Expires", _collection._Expires);
                        _state = 19;
                        return true;
                    }
                
                state19:
                    if (((_bits & 524288L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Last-Modified", _collection._LastModified);
                        _state = 20;
                        return true;
                    }
                
                state20:
                    if (((_bits & 1048576L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Accept-Ranges", _collection._AcceptRanges);
                        _state = 21;
                        return true;
                    }
                
                state21:
                    if (((_bits & 2097152L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Age", _collection._Age);
                        _state = 22;
                        return true;
                    }
                
                state22:
                    if (((_bits & 4194304L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("ETag", _collection._ETag);
                        _state = 23;
                        return true;
                    }
                
                state23:
                    if (((_bits & 8388608L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Location", _collection._Location);
                        _state = 24;
                        return true;
                    }
                
                state24:
                    if (((_bits & 16777216L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Proxy-Autheticate", _collection._ProxyAutheticate);
                        _state = 25;
                        return true;
                    }
                
                state25:
                    if (((_bits & 33554432L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Retry-After", _collection._RetryAfter);
                        _state = 26;
                        return true;
                    }
                
                state26:
                    if (((_bits & 67108864L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Server", _collection._Server);
                        _state = 27;
                        return true;
                    }
                
                state27:
                    if (((_bits & 134217728L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Set-Cookie", _collection._SetCookie);
                        _state = 28;
                        return true;
                    }
                
                state28:
                    if (((_bits & 268435456L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("Vary", _collection._Vary);
                        _state = 29;
                        return true;
                    }
                
                state29:
                    if (((_bits & 536870912L) != 0))
                    {
                        _current = new KeyValuePair<string, string[]>("WWW-Authenticate", _collection._WWWAuthenticate);
                        _state = 30;
                        return true;
                    }
                
                state_default:
                    if (!_hasUnknown || !_unknownEnumerator.MoveNext())
                    {
                        _current = default(KeyValuePair<string, string[]>);
                        return false;
                    }
                    _current = _unknownEnumerator.Current;
                    return true;
            }
        }
    }
}
