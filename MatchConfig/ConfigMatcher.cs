using System;
using MatchConfig.Matchers;

namespace MatchConfig
{
    public class ConfigMatcher
    {
        #region Private Members
        private VmessMatcher _vmess;
        private VlessMatcher _vless;
        private TrojanMatcher _trojan;
        private ShadowSocksMatcher _shadowsocks;
        private TelegramProxyMatcher _telegramProxy;
        #endregion

        #region Public Members

        public VmessMatcher VmessProxy
        {
            get
            {
                if (_vmess == null)
                {
                    _vmess = new VmessMatcher();
                    return _vmess;
                }
                return _vmess;
            }
        }
        public VlessMatcher VlessProxy
        {
            get
            {
                if (_vless == null)
                {
                    _vless = new VlessMatcher();
                    return _vless;
                }
                return _vless;
            }
        }
        public TrojanMatcher TrojanProxy
        {
            get
            {
                if (_trojan == null)
                {
                    _trojan = new TrojanMatcher();
                    return _trojan;
                }

                return _trojan;
            }
        }
        public ShadowSocksMatcher ShadowSocksProxy
        {
            get
            {
                if (_shadowsocks == null)
                {
                    _shadowsocks = new ShadowSocksMatcher();
                    return _shadowsocks;
                }
                return _shadowsocks;
            }
        }
        public TelegramProxyMatcher TelegramProxy
        {
            get
            {
                if (_telegramProxy == null)
                {
                    _telegramProxy = new TelegramProxyMatcher();
                    return _telegramProxy;
                }

                return _telegramProxy;
            }
        }

        #endregion
    }
}
