dnl
dnl $Id: config.m4 291957 2009-12-10 17:13:14Z cyberspice $
dnl 

PHP_ARG_ENABLE(dio, whether to enable direct I/O support,
[  --enable-dio            Enable direct I/O support])

if test "$PHP_DIO" != "no"; then
  PHP_NEW_EXTENSION(dio, dio.c dio_common.c dio_posix.c dio_stream_wrappers.c, $ext_shared)
fi
