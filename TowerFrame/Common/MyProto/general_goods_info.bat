call python xls_deploy_tool.py GOODS_INFO xls/goods_info.xls
call xls\protoc tnt_deploy_goods_info.proto --descriptor_set_out=goods_info.protodesc
call bin\protogen -i:goods_info.protodesc -o:goods_info.cs
pause