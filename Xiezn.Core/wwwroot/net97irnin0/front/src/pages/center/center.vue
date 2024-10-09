<template>
<div class="center-preview" :style='{"padding":"0 5%","margin":"10px auto","flexWrap":"wrap","background":"#fff","display":"flex","width":"100%","position":"relative"}'>
	<div class="title" :style='{"margin":"10px auto","color":"#DF847F","textAlign":"center","background":"url(http://codegen.caihongy.cn/20231220/e54f6cd4929f4d00b2ead8e5a5991d16.png)","width":"80%","fontSize":"24px","lineHeight":"54px","backgroundSize":"cover","backgroundPosition":"center center","backgroundRepeat":"no-repeat","fontWeight":"bold"}'>{{ title }}</div>
	
	<div class="info" :style='{"border":"2px solid #DF847F","padding":"50px 120px 100px","boxShadow":"none","margin":"20px auto 100px","alignItems":"flex-start","flexDirection":"column","display":"flex","borderRadius":"0","flexWrap":"wrap","background":"#ffffff","width":"100%","position":"relative","height":"254px"}'>
		<div :style='{"borderColor":"#efefef","color":"#333","borderWidth":"0 0 1px 0","display":"none","width":"100%","lineHeight":"44px","fontSize":"15px","borderStyle":"solid","height":"44px"}'>个人信息</div>
		<div :style='{"borderColor":"#efefef","margin":"0 0 0 15px","borderWidth":"0","width":"auto","fontSize":0,"borderStyle":"solid","height":"auto"}' v-if="userTableName=='yonghu'">
			<el-image :style='{"margin":"0 auto","borderColor":"#efefef","objectFit":"cover","borderRadius":"100%","borderWidth":"0 0 1px 0","display":"block","width":"100px","borderStyle":"solid","height":"100px"}' :src="sessionForm.touxiang?baseUrl + sessionForm.touxiang:require('@/assets/avator.png')" fit="cover"></el-image>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","borderWidth":"0","display":"flex","width":"100%","lineHeight":"40px","borderStyle":"solid","height":"auto"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#333","fontSize":"14px","display":"none"}'>用户名</div>
			<div :style='{"fontSize":"18px","color":"#000","flex":1,"fontWeight":"bold"}'>{{sessionForm.yonghuming}}</div>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","borderWidth":"0","display":"flex","width":"100%","lineHeight":"40px","borderStyle":"solid","height":"auto"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#000","padding":"0 5px 0 0","fontSize":"16px"}'>姓名</div>
			<div :style='{"fontSize":"16px","color":"#000","textAlign":"left","fontWeight":"bold"}'>{{sessionForm.xingming}}</div>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","alignItems":"center","bottom":"-75px","display":"flex","justifyContent":"center","left":"120px","borderWidth":"0","background":"url(http://codegen.caihongy.cn/20231222/faf48fa893634aeeb23463c91935e315.png)","width":"18%","lineHeight":"40px","backgroundSize":"100% 100%","position":"absolute","backgroundPosition":"center center","borderStyle":"solid","backgroundRepeat":"no-repeat","height":"150px"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#000","padding":"24px 10px 0 0","fontSize":"14px"}'>性别</div>
			<div :style='{"padding":"24px 0 0","fontSize":"14px","color":"#000","fontWeight":"bold"}'>{{sessionForm.xingbie}}</div>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","alignItems":"center","bottom":"-75px","display":"flex","justifyContent":"center","left":"calc(18% + 190px)","borderWidth":"0","background":"url(http://codegen.caihongy.cn/20231222/faf48fa893634aeeb23463c91935e315.png)","width":"18%","lineHeight":"40px","backgroundSize":"100% 100%","position":"absolute","backgroundPosition":"center center","borderStyle":"solid","backgroundRepeat":"no-repeat","height":"150px"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#000","padding":"24px 10px 0 0","fontSize":"14px"}'>手机</div>
			<div :style='{"padding":"24px 0 0","fontSize":"14px","color":"#000","textAlign":"left","fontWeight":"bold"}'>{{sessionForm.shouji}}</div>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","alignItems":"center","bottom":"-75px","display":"flex","right":"calc(18% + 190px)","justifyContent":"center","borderWidth":"0","background":"url(http://codegen.caihongy.cn/20231222/faf48fa893634aeeb23463c91935e315.png)","width":"18%","lineHeight":"40px","backgroundSize":"100% 100%","position":"absolute","backgroundPosition":"center center","borderStyle":"solid","backgroundRepeat":"no-repeat","height":"150px"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#000","padding":"24px 10px 0 0","fontSize":"14px"}'>年龄</div>
			<div :style='{"padding":"24px 0 0","fontSize":"14px","color":"#000","textAlign":"left","fontWeight":"bold"}'>{{sessionForm.nianling}}</div>
		</div>
		<div :style='{"padding":"0 20px","borderColor":"#efefef","alignItems":"center","bottom":"-75px","display":"flex","right":"120px","justifyContent":"center","borderWidth":"0","background":"url(http://codegen.caihongy.cn/20231222/faf48fa893634aeeb23463c91935e315.png)","width":"18%","lineHeight":"40px","backgroundSize":"100% 100%","position":"absolute","backgroundPosition":"center center","borderStyle":"solid","backgroundRepeat":"no-repeat","height":"150px"}' v-if="userTableName=='yonghu'">
			<span class="icon iconfont icon-shouye-zhihui" :style='{"padding":"0 5px","fontSize":"14px","color":"#333","display":"none"}'></span>
			<div :style='{"color":"#000","padding":"24px 10px 0 0","fontSize":"14px"}'>积分</div>
			<div :style='{"padding":"24px 0 0","fontSize":"14px","color":"#000","textAlign":"left","fontWeight":"bold"}'>{{sessionForm.jf}}</div>
		</div>
		
	</div>
	
    <el-tabs tab-position="left" :style='{"border":"2px solid #DF847F","width":"100%","flexWrap":"wrap","background":"none","borderWidth":"0 2px 2px","display":"flex"}' @tab-click="handleClick">
      <el-tab-pane label="个人中心">
        <el-form class="center-preview-pv" ref="sessionForm" :model="sessionForm" :rules="rules" label-width="80px">
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="用户名" prop="yonghuming">
            <el-input v-model="sessionForm.yonghuming" placeholder="用户名" readonly></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="姓名" prop="xingming">
            <el-input v-model="sessionForm.xingming" placeholder="姓名" ></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="头像" prop="touxiang">
			<file-upload
			tip="点击上传头像"
			action="file/upload"
			:limit="1"
			:multiple="true"
			:fileUrls="sessionForm.touxiang?sessionForm.touxiang:''"
			@change="yonghutouxiangHandleAvatarSuccess"
			></file-upload>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="性别" prop="xingbie">
            <el-select v-model="sessionForm.xingbie" placeholder="请选择性别" >
              <el-option v-for="(item, index) in dynamicProp.xingbie" :key="index" :label="item" :value="item"></el-option>
            </el-select>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="手机" prop="shouji">
            <el-input v-model="sessionForm.shouji" placeholder="手机" ></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="年龄" prop="nianling">
            <el-input v-model="sessionForm.nianling" placeholder="年龄" ></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="积分">
            <el-input v-model="sessionForm.jf" placeholder="积分" readonly></el-input>
          </el-form-item>
          <el-form-item class="balance" :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="余额">
            <div :style='{"flexWrap":"wrap","display":"flex"}'>
				<el-input v-model="sessionForm.money" placeholder="余额" readonly></el-input>
				<div @click="dialogFormVisibleMoney = true" :style='{"border":"0","cursor":"pointer","padding":"0 15px","margin":"0 0 0 10px","color":"rgba(255, 255, 255, 1)","display":"inline-block","outline":"none","borderRadius":"0","background":"#DF847F","width":"100px","lineHeight":"50px","fontSize":"14px","height":"50px"}'>点我充值</div>
			</div>
		  </el-form-item>
          <el-form-item class="balance" :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' v-if="userTableName=='yonghu'" label="会员">
            <div :style='{"flexWrap":"wrap","display":"flex"}'>
				<el-input v-model="sessionForm.vip" placeholder="会员" readonly></el-input>
				<div @click="dialogFormVisibleVip = true" :style='{"border":"0","cursor":"pointer","padding":"0 15px","margin":"0 0 0 10px","color":"rgba(255, 255, 255, 1)","display":"inline-block","outline":"none","borderRadius":"0","background":"#DF847F","width":"100px","lineHeight":"50px","fontSize":"14px","height":"50px"}'>会员购买</div>
			</div>
		  </el-form-item>
          <el-form-item :style='{"padding":"0","margin":"0"}'>
            <el-button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"0 20px 0 0","outline":"none","color":"rgba(255, 255, 255, 1)","borderRadius":"4px","background":"#DF847F","width":"auto","lineHeight":"30px","fontSize":"14px","height":"30px"}' type="primary" @click="onSubmit('sessionForm')">更新信息</el-button>
            <el-button :style='{"border":"0px solid rgba(64, 158, 255, 1)","cursor":"pointer","padding":"0 10px","margin":"0","outline":"none","color":"#fff","borderRadius":"4px","background":"#8FD5E7","width":"auto","lineHeight":"30px","fontSize":"14px","height":"30px"}' type="danger" @click="logout">退出登录</el-button>
          </el-form-item>
        </el-form>
      </el-tab-pane>
	  <el-tab-pane label="修改密码">
		<el-form class="center-preview-pv" ref="passwordForm" :model="passwordForm" :rules="passwordRules" label-width="80px">
			<el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' label="原密码" prop="password">
			  <el-input type="password" v-model="passwordForm.password" placeholder="原密码"></el-input>
			</el-form-item>
			<el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' label="新密码" prop="newpassword">
			  <el-input type="password" v-model="passwordForm.newpassword" placeholder="新密码"></el-input>
			</el-form-item>
			<el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"#fff"}' label="确认密码" prop="repassword">
			  <el-input type="password" v-model="passwordForm.repassword" placeholder="确认密码"></el-input>
			</el-form-item>
			<el-form-item :style='{"padding":"0","margin":"0"}'>
			  <el-button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"0 20px 0 0","outline":"none","color":"rgba(255, 255, 255, 1)","borderRadius":"4px","background":"#DF847F","width":"auto","lineHeight":"30px","fontSize":"14px","height":"30px"}' type="primary" @click="updatePassword">修改密码</el-button>
			</el-form-item>
		</el-form>
	  </el-tab-pane>
      <el-tab-pane label="我的订单"></el-tab-pane>
      <el-tab-pane label="我的地址" name="MyAddress">
        <router-view></router-view>
      </el-tab-pane>
      <el-tab-pane label="我的收藏"></el-tab-pane>
      <el-tab-pane label="我的优惠券">
		  <div class="coupon_list">
		  	<div class="coupon" v-for="(item,index) in couponList" :key="index" :class="(item.status=='已过期'||item.status=='已使用')?'coupons':''">
		  		<div class="coupon_left">
		  			<div class="name">{{item.name}}</div>
		  			<div class="name">满{{item.fullamount}}减{{item.discountamount}}</div>
		  			<div class="date">{{item.startime}}-{{item.endtime}}</div>
					<div class="date">{{item.couponnumber}}</div>
					<div class="date">{{item.remark}}</div>
		  		</div>
		  		<div class="coupon_right">
		  			<div class="price">￥<span class="num">{{item.discountamount}}</span></div>
					<div class="btn" v-if="item.status=='可使用'">{{item.status}}</div>
		  		</div>
		  		<img v-if="item.status=='已过期'" class="no-coupon" src="@/assets/no-coupon.png" alt="">
		  		<img v-if="item.status=='已使用'" class="no-coupon" src="@/assets/finish-coupon.png" alt="">
		  	</div>
		  	<div class="noList" v-if="!couponList.length">
		  		暂无优惠券
		  	</div>
		  </div>
	  </el-tab-pane>
    </el-tabs>

	<el-dialog title="用户充值" :visible.sync="dialogFormVisibleMoney" width="726px" center>
	  <el-form :model="chongzhiForm">
		<el-form-item label="充值金额" label-width="120px">
		  <el-input type="number" v-model="chongzhiForm.money" autocomplete="off" placeholder="充值金额"></el-input>
		</el-form-item>
		<el-form-item label-width="120px">
		  <el-radio-group v-model="chongzhiForm.radio">
			<el-radio style="margin-bottom: 30px" label="微信支付">
			  <el-image
				style="width: 60px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/weixin.png')"
				fit="fill"></el-image>
				<span style="display: inline-block;margin-left: 10px">微信支付</span>
			</el-radio>
			<el-radio label="支付宝支付">
			  <el-image
				style="width: 60px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/zhifubao.png')"
				fit="fill"></el-image>
				<span style="display: inline-block;margin-left: 10px">支付宝支付</span>
			</el-radio>
			<el-radio label="中国建设银行支付">
			  <el-image
				style="width: 120px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/jianshe.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="中国农业银行支付">
			  <el-image
				style="width: 126px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/nongye.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="中国银行支付">
			  <el-image
				style="width: 140px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/zhongguo.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="交通银行支付">
			  <el-image
				style="width: 120px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/jiaotong.png')"
				fit="fill"></el-image>
			</el-radio>
		  </el-radio-group>
		</el-form-item>
	  </el-form>
	  <div slot="footer" class="dialog-footer">
		<el-button @click="dialogFormVisibleMoney = false">取 消</el-button>
		<el-button type="primary" @click="chongzhi">确认充值</el-button>
	  </div>
	</el-dialog>
	<el-dialog title="会员购买" :visible.sync="dialogFormVisibleVip" width="726px" center>
	  <el-form :model="chongzhiForm">
		<el-form-item label="会员卡" label-width="120px">
		  <el-input readonly autocomplete="off" value="￥199/年"></el-input>
		</el-form-item>
		<el-form-item label-width="120px">
		  <el-radio-group v-model="chongzhiForm.radio">
			<el-radio style="margin-bottom: 30px" label="微信支付">
			  <el-image
				style="width: 60px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/weixin.png')"
				fit="fill"></el-image>
				<span style="display: inline-block;margin-left: 10px">微信支付</span>
			</el-radio>
			<el-radio label="支付宝支付">
			  <el-image
				style="width: 60px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/zhifubao.png')"
				fit="fill"></el-image>
				<span style="display: inline-block;margin-left: 10px">支付宝支付</span>
			</el-radio>
			<el-radio label="中国建设银行支付">
			  <el-image
				style="width: 120px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/jianshe.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="中国农业银行支付">
			  <el-image
				style="width: 126px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/nongye.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="中国银行支付">
			  <el-image
				style="width: 140px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/zhongguo.png')"
				fit="fill"></el-image>
			</el-radio>
			<el-radio label="交通银行支付">
			  <el-image
				style="width: 120px; height: 60px;vertical-align: middle;"
				:src="require('@/assets/jiaotong.png')"
				fit="fill"></el-image>
			</el-radio>
		  </el-radio-group>
		</el-form-item>
	  </el-form>
	  <div slot="footer" class="dialog-footer">
		<el-button @click="dialogFormVisibleVip = false">取 消</el-button>
		<el-button type="primary" @click="chongzhivip">确认支付</el-button>
	  </div>
	</el-dialog>
</div>
</template>

<script>
  import config from '@/config/config'
  import Vue from 'vue'
  export default {
    //数据集合
    data() {
      return {
        title: '个人中心',
        baseUrl: config.baseUrl,
        sessionForm: {},
		passwordForm: {},
		passwordRules: {
			password: [
				{
					required: true,
					message: "密码不能为空",
					trigger: "blur"
				}
			],
			newpassword: [
				{
					required: true,
					message: "新密码不能为空",
					trigger: "blur"
				}
			],
			repassword: [
				{
					required: true,
					message: "确认密码不能为空",
					trigger: "blur"
				}
			]
		},
        rules: {},
        chongzhiForm: {
          money: '',
          radio: ''
        },
        disabled: false,
        dialogFormVisibleMoney: false,
        dialogFormVisibleVip: false,
        uploadUrl: config.baseUrl + 'file/upload',
        imageUrl: '',
        headers: {Token: localStorage.getItem('frontToken')},
        userTableName: localStorage.getItem('UserTableName'),
        dynamicProp: {},
		couponList: [],
      }
    },
    created() {
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'yonghuming', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'mima', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'xingming', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'touxiang', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'xingbie', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'shouji', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'nianling', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'jf', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'money', null);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.sessionForm, 'vip', null);
		}

		if ('yonghu' == this.userTableName&&this.rules['yonghuming']){
			this.rules['yonghuming'].push({ required: true, message: '请输入用户名', trigger: 'blur' })
		}else if('yonghu' == this.userTableName&&!this.rules['yonghuming']) {
			this.$set(this.rules, 'yonghuming', [{ required: true, message: '请输入用户名', trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName&&this.rules['mima']){
			this.rules['mima'].push({ required: true, message: '请输入密码', trigger: 'blur' })
		}else if('yonghu' == this.userTableName&&!this.rules['mima']) {
			this.$set(this.rules, 'mima', [{ required: true, message: '请输入密码', trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName&&this.rules['xingming']){
			this.rules['xingming'].push({ required: true, message: '请输入姓名', trigger: 'blur' })
		}else if('yonghu' == this.userTableName&&!this.rules['xingming']) {
			this.$set(this.rules, 'xingming', [{ required: true, message: '请输入姓名', trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.rules, 'shouji', [{ required: false, validator: this.$validate.isMobile, trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.rules, 'nianling', [{ required: false, validator: this.$validate.isIntNumer, trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.rules, 'jf', [{ required: false, validator: this.$validate.isNumber, trigger: 'blur' }]);
		}
		if ('yonghu' == this.userTableName) {
			this.$set(this.rules, 'money', [{ required: false, validator: this.$validate.isNumber, trigger: 'blur' }]);
		}

      this.init();
      this.sessionForm = JSON.parse(localStorage.getItem('sessionForm'))
    },
    //方法集合
    methods: {
      init() {
        if ('yonghu' == this.userTableName) {
          this.dynamicProp.xingbie = '男,女'.split(',');
        }
        if ('yonghu' == this.userTableName) {
          this.dynamicProp.vip = '是,否'.split(',');
        }
      },
	  setSession(){
		  localStorage.setItem('sessionForm',JSON.stringify(this.sessionForm))
	  },
      onSubmit(formName) {
		if(`yonghu` == this.userTableName && this.sessionForm.touxiang!=null){
			this.sessionForm.touxiang = this.sessionForm.touxiang.replace(new RegExp(this.$config.baseUrl,"g"),"");
		}
        this.$refs[formName].validate((valid) => {
			if (valid) {
				this.$http.post(this.userTableName + '/update', this.sessionForm).then(res => {
					if (res.data.code == 0) {
						this.setSession()
						this.$message({
							message: '更新成功',
							type: 'success',
							duration: 1500
						});
					}
				});
			} else {
				return false;
			}
        });
      },
      yonghutouxiangHandleAvatarSuccess(fileUrls) {
        this.sessionForm.touxiang = fileUrls;
      },
      chongzhi() {
        if (this.chongzhiForm.money == '') {
          this.$message({
            message: '请输入充值金额',
            type: 'error',
            duration: 1500
          });
          return;
        }
        if (this.chongzhiForm.money <= 0) {
          this.$message({
            message: '请输入正确的充值金额',
            type: 'error',
            duration: 1500
          });
          return;
        }
        if (this.chongzhiForm.radio == '') {
          this.$message({
            message: '请选择充值方式',
            type: 'error',
            duration: 1500
          });
          return;
        }
		if(!this.sessionForm.money) {
			this.sessionForm.money = parseFloat(this.chongzhiForm.money)
		}else{
			this.sessionForm.money = parseFloat(this.sessionForm.money) + parseFloat(this.chongzhiForm.money);
		}
        
        this.$http.post(this.userTableName + '/update', this.sessionForm).then(res => {
          if (res.data.code == 0) {
			  this.setSession()
            this.$message({
              message: '充值成功',
              type: 'success',
              duration: 1500,
              onClose: () => {
                this.dialogFormVisibleMoney = false;
              }
            });
          }
        });
      },
      chongzhivip() {
        this.chongzhiForm.money == 199;
        if (this.chongzhiForm.radio == '') {
          this.$message({
            message: '请选择支付方式',
            type: 'error',
            duration: 1500
          });
          return;
        }
        if(this.sessionForm.vip == '是') {
          this.$message({
            message: '您已是我们的尊贵会员。',
            type: 'success',
            duration: 1500
          });
          return;
        }
        
        this.sessionForm.vip = "是"
        this.$http.post(this.userTableName + '/update', this.sessionForm).then(res => {
          if (res.data.code == 0) {
			  this.setSession()
            this.$message({
              message: '会员购买成功',
              type: 'success',
              duration: 1500,
              onClose: () => {
                localStorage.setItem('vip', this.sessionForm.vip);
                this.dialogFormVisibleVip = false;
              }
            });
          }
        });
      },
      handleClick(tab, event) {
        switch(event.target.outerText) {
          case '个人中心':
            tab.$router.push('/index/center');
            break;
          case '修改密码':
            this.passwordForm = {
				password: '',
				newpassword: '',
				repassword: '',
			}
			this.$forceUpdate()
            break;
          case '我的订单':
            tab.$router.push('/index/shop-order/order');
            break;
          case '我的地址':
            tab.$router.push('/index/shop-address/list');
            break;
          case '我的收藏':
            localStorage.setItem('storeupType', 1);
            tab.$router.push('/index/storeup');
            break;
		  case '我的优惠券':
			this.getMyList()
		    break;
		  default:
		  	tab.$router.push(`/index/${tab.name}?centerType=1`);
        }

        this.title = event.target.outerText;
      },
	  async updatePassword(){
			this.$refs["passwordForm"].validate(async valid => {
				if (valid) {
					var password = "";
					if (this.sessionForm.mima) {
						password = this.sessionForm.mima;
					} else if (this.sessionForm.password) {
						password = this.sessionForm.password;
					}
					var nowpassword = ''
					await this.$http.get('encrypt/md5?text=' + this.passwordForm.password,).then(res=>{
						if(res.data&&res.data.code==0){
							nowpassword = res.data.data
						}
					})
					if(nowpassword!=password){
						this.$message.error("原密码错误");
						return;
					}
					if (this.passwordForm.newpassword != this.passwordForm.repassword) {
						this.$message.error("两次密码输入不一致");
						return;
					}
					if (this.passwordForm.newpassword == this.passwordForm.password) {
						this.$message.error("新密码与原密码相同！");
						return;
					}
					if (this.userTableName == 'yonghu') {
					}
					this.sessionForm.password = this.passwordForm.newpassword;
					this.sessionForm.mima = this.passwordForm.newpassword;
					this.$http.post(`${this.userTableName}/update`,this.sessionForm).then(({data})=>{
						if (data && data.code === 0) {
							this.$message({
								message: "修改密码成功,下次登录系统生效",
								type: "success",
								duration: 1500,
								onClose: () => {
								}
							});
							this.setSession()
						} else {
							this.$message.error(data.msg);
						}
					});
				}
			})
	  },
      logout() {
        localStorage.clear();
        Vue.http.headers.common['Token'] = "";
        this.$router.push('/index/home');
        this.activeIndex = '0'
        localStorage.setItem('keyPath', this.activeIndex)
        this.$forceUpdate()
        this.$message({
            message: '登出成功',
            type: 'success',
            duration: 1500,
        });
      },
	  getMyList() {
	  	this.$http.get('mycoupon/page').then(res => {
	  		if (res.data && res.data.code == 0) {
	  			for (let x in res.data.data.list) {
	  				if (!this.isBetweenTime(this.getCurDateTime(), [res.data.data.list[x].startime, res
	  						.data.data.list[x].endtime
	  					]) && res.data.data.list[x].status != '已使用' && res.data.data.list[x].status !=
	  					'已过期') {
	  					res.data.data.list[x].status = '已过期'
	  					this.$http.post('mycoupon/update', res.data.data.list[x]).then(obj => {})
	  				} else if (this.isBetweenTime(this.getCurDateTime(), [res.data.data.list[x]
	  						.startime, res.data.data.list[x].endtime
	  					]) && res.data.data.list[x].status != '已使用' && res.data.data.list[x].status !=
	  					'可使用') {
	  					res.data.data.list[x].status = '可使用'
	  					this.$http.post('mycoupon/update', res.data.data.list[x]).then(obj => {})
	  				}
	  
	  			}
	  			this.couponList = res.data.data.list
	  		}
	  	})
	  },
	  isBetweenTime(currentDate, timeQuantum) {
	  	let isBetween = true;
	  	let currentTime = new Date(currentDate);
	  	let startTime = new Date(timeQuantum[0]);
	  	let endTime = new Date(timeQuantum[1]);
	  	let t1 = currentTime.getTime() - startTime.getTime();
	  	let t2 = currentTime.getTime() - endTime.getTime();
	  	if (t1 < 0 || t2 > 0) {
	  		isBetween = false;
	  	}
	  	return isBetween;
	  },
    }
  }
</script>

<style rel="stylesheet/scss" lang="scss" scoped>
  .center-preview {
  
    .el-tabs {
      & /deep/ .el-tabs__header {
		.el-tabs__nav{
			overflow: auto;
		}
		::-webkit-scrollbar {
		  -webkit-appearance: none;
		  width: 6px;
		  height: 6px;
		}
		::-webkit-scrollbar-track {
		  background: rgba(0, 0, 0, 0.1);
		  border-radius: 0;
		}
		::-webkit-scrollbar-thumb {
		  cursor: pointer;
		  border-radius: 5px;
		  background: rgba(0, 0, 0, 0.15);
		  transition: color 0.2s ease;
		}
		::-webkit-scrollbar-thumb:hover {
		  background: rgba(0, 0, 0, 0.3);
		}
        .el-tabs__nav-wrap {
          margin: 0;
  
          &::after {
            content: none;
          }
        }
  
        .el-tabs__active-bar {
          display: none !important;
        }
      }
  
      .center-preview-pv {
        .el-date-editor.el-input {
          width: auto;
        }
  
        .balance {
          .el-input {
            width: auto;
          }
        }
      }
    }
  }
  
  .center-preview .el-tabs /deep/ .el-tabs__header {
	padding: 0;
	margin: 0;
	background: #DF847F;
	display: flex;
	width: 100%;
	border-color: #eee;
	border-width: 0;
	justify-content: center;
	position: relative;
	float: left;
	border-style: solid;
	height: auto;
  }
  
  .center-preview .el-tabs /deep/ .el-tabs__header .el-tabs__item {
  	padding: 0 10px;
  	margin: 0 20px;
  	color: #000;
  	background: none;
  	font-weight: bold;
  	display: inline-block;
  	font-size: 14px;
  	line-height: 60px;
  	position: relative;
  	text-align: center;
  	height: 60px;
  }
  
  .center-preview .el-tabs /deep/ .el-tabs__header .el-tabs__item:hover {
  	padding: 0 10px;
  	margin: 0 20px;
  	color: #DF847F;
  	background: #fff;
  	font-weight: bold;
  	display: inline-block;
  	font-size: 14px;
  	line-height: 60px;
  	position: relative;
  	text-align: center;
  	height: 60px;
  }
  
  .center-preview .el-tabs /deep/ .el-tabs__header .el-tabs__item.is-active {
  	padding: 0 10px;
  	margin: 0 20px;
  	color: #DF847F;
  	background: #fff;
  	font-weight: bold;
  	display: inline-block;
  	font-size: 14px;
  	line-height: 60px;
  	position: relative;
  	text-align: center;
  	height: 60px;
  }
  
  .center-preview .el-tabs /deep/ .el-tabs__content {
  	padding: 10px;
  	background: #fff;
  	width: 100%;
  }
  .center-preview .el-tabs /deep/ .el-tabs__content .el-tab-pane {
  }
  
  .center-preview-pv .el-form-item /deep/ .el-form-item__label {
  	padding: 0 10px 0 0;
  	color: #666;
  	font-weight: 500;
  	width: 80px;
  	font-size: 14px;
  	line-height: 40px;
  	text-align: right;
  }
  
  .center-preview-pv .el-form-item .el-form-item__content {
    margin-left: 80px;
  }
  
  .center-preview-pv .el-input /deep/ .el-input__inner {
  	border: 1px solid #CDCDCD;
  	border-radius: 0;
  	padding: 0 12px;
  	box-shadow: none;
  	outline: none;
  	color: #000;
  	width: 500px;
  	font-size: 16px;
  	height: 50px;
  }
  
  .center-preview-pv .el-select /deep/ .el-input__inner {
  	border: 1px solid #CDCDCD;
  	border-radius: 0;
  	padding: 0 12px;
  	box-shadow: none;
  	outline: none;
  	color: #000;
  	width: 500px;
  	font-size: 16px;
  	height: 50px;
  }
  
  .center-preview-pv .el-date-editor /deep/ .el-input__inner {
  	border: 1px solid #CDCDCD;
  	border-radius: 0;
  	padding: 0 10px 0 30px;
  	box-shadow: none;
  	outline: none;
  	color: #000;
  	width: 500px;
  	font-size: 14px;
  	height: 50px;
  }
  
  .center-preview-pv /deep/ .avatar-uploader-icon {
  	border: 1px solid #CDCDCD;
  	cursor: pointer;
  	border-radius: 6px;
  	color: #3d3d3d;
  	width: 200px;
  	font-size: 32px;
  	line-height: 60px;
  	text-align: center;
  	height: 60px;
  }
  
  .center-preview-pv .el-form-item.balance /deep/ .el-input__inner {
  	border: 1px solid #CDCDCD;
  	border-radius: 0;
  	padding: 0 12px;
  	box-shadow: none;
  	outline: none;
  	color: #000;
  	display: inline-block;
  	width: 390px;
  	font-size: 14px;
  	height: 50px;
  }
  .coupon_list {
  	width: 100%;
  	display: flex;
  	flex-wrap: wrap;
  
  	.coupon {
  		width: 49%;
  		margin: 0 1% 20px 0;
  		background: url('../../assets/coupon.png');
  		background-repeat: no-repeat;
  		background-position: center center;
  		background-size: cover;
  		padding: 60px 30px;
  		display: flex;
  		align-items: center;
  
  		position: relative;
  
  		.no-coupon {
  			position: absolute;
  			width: 80px;
  			right: 20px;
  			top: 20px;
  		}
  
  		.coupon_left {
  			flex: 1;
  			color: #000;
  
  			.name {
  				font-size: 22px;
  				line-height: 1.5;
  			}
  
  			.date {
  				font-size: 14px;
  				line-height: 1.5;
  			}
			.date1 {
				font-size: 12px;
				line-height: 1.5;
				color: #FF0800;
			}
  		}
  
  		.coupon_right {
  			display: flex;
  			flex-direction: column;
  			align-items: center;
  
  			.price {
  				color: #FF0800;
  				font-size: 20px;
  				padding: 0 0 10px;
  
  				.num {
  					font-size: 28px;
  				}
  			}
  
  			.btn {
  				width: 100px;
  				height: 30px;
  				line-height: 30px;
  				border-radius: 30px;
  				background: #FF0800;
  				text-align: center;
  				color: #fff;
  				font-size: 18px;
  				cursor: pointer;
  			}
  		}
  	}
  
  	.coupons {
  		filter: grayscale(100%);
  	}
  
  	.noList {
  		color: #9e9e9e;
  		width: 100%;
  		text-align: center;
  		padding: 60px 0;
  	}
  }
</style>
