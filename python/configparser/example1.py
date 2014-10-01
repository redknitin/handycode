import configparser
cfg = configparser.ConfigParser()
cfg.read('settings.ini')
toaddr = cfg['General']['SysAdminEmail']

#
# --settings.ini below--
#
#[General]
#SysAdminEmail=nospam@nospam.org
