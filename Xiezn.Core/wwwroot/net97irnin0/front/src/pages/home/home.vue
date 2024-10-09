<template>
<div class="home-preview" :style='{"width":"100%","margin":"0 auto","position":"relative","alignItems":"flex-start","flexWrap":"wrap","display":"flex"}'>

	<!-- 搜索 -->
	<div id="search" class="search animate__animated" :style='{"padding":"0 10%","margin":"0","alignItems":"center","borderRadius":"0","flexWrap":"wrap","background":"#DF847F","display":"flex","width":"100%","justifyContent":"flex-end","height":"120px","order":"1","zIndex":"111"}'>
		<div :style='{"margin":"0 10px 0 0"}' class="select">
			<el-select v-model="queryIndex">
				<el-option
				  v-for="(item,index) in queryList"
				  :key="index"
				  :label="item.queryName"
				  :value="index"
				></el-option>
			</el-select>
		</div>
		<div :style='{"margin":"0 10px 0 0"}' class="input" v-if="queryIndex==0">
			<el-input v-model="xianhuaxinxixianhuamingcheng" placeholder="鲜花名称"></el-input>
		</div>
		<div :style='{"padding":"0","margin":"0"}' class="btn" v-if="queryIndex==0">
			<el-button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"0","outline":"none","color":"#DF847F","borderRadius":"40px","background":"#fff","width":"120px","lineHeight":"60px","fontSize":"0","height":"60px"}' type="primary" @click="search('xianhuaxinxi')">
				<span class="icon iconfont icon-fangdajing07" :style='{"color":"#DF847F","margin":"0 4px 0 0","fontSize":"24px"}'></span>
				搜索
			</el-button>
		</div>
	</div>
	<!-- 搜索 -->


		<!-- 关于我们 -->
		<div id="about" class="animate__animated" :style='{"padding":"70px 30px 100px 10%","boxShadow":"0 1px 6px rgba(255, 255, 255, .3)","margin":"0 0 0","flexWrap":"wrap","background":"linear-gradient(180deg, #F0D1CF 0%, #FFD1CE 100%)","display":"flex","width":"50%","position":"relative","height":"auto","order":"5"}'>
		  <div :style='{"border":"1px solid #BFF2FF","margin":"0 20px","color":"#000","textAlign":"center","borderWidth":"0 0 2px","width":"100%","lineHeight":"1.5","fontSize":"30px","fontWeight":"bold","order":"1","zIndex":"1"}'>{{aboutUsDetail.title}}</div>
		  <div :style='{"margin":"0 0 10px","color":"#999","textAlign":"center","display":"none","width":"100%","lineHeight":"1.5","fontSize":"20px"}'>{{aboutUsDetail.subtitle}}</div>
		  <div :style='{"border":"5px solid #BFF2FF","padding":"0 0 20px","margin":"-380px 0 0","borderRadius":"20px","alignItems":"flex-end","background":"#fff","display":"flex","width":"100%","height":"520px","order":"3"}'>
		    <img :style='{"margin":"0 10px","objectFit":"cover","flex":1,"display":"block","height":"120px"}' :src="baseUrl + aboutUsDetail.picture1">
		    <img :style='{"margin":"0 10px","objectFit":"cover","flex":1,"display":"block","height":"120px"}' :src="baseUrl + aboutUsDetail.picture2">
		    <img :style='{"margin":"0 10px","objectFit":"cover","flex":1,"display":"block","height":"120px"}' :src="baseUrl + aboutUsDetail.picture3">
		  </div>
		  <div :style='{"padding":"20px 20px 0","margin":"50px 0 ","color":"#000","display":"-webkit-box","overflow":"hidden","width":"100%","lineHeight":"1.6","fontSize":"16px","textOverflow":"ellipsis","-webkit-box-orient":"vertical","-webkit-line-clamp":"7","order":"2","zIndex":"1","height":"200px"}' v-html="aboutUsDetail.content"></div>
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"border":"1px solid #80BBCA","cursor":"pointer","margin":"10px auto","top":"65px","textAlign":"center","background":"none","display":"block","width":"100px","lineHeight":"30px","position":"absolute","right":"50px","zIndex":"999"}' @click="toDetail('aboutusDetail',aboutUsDetail)">
		    <span :style='{"color":"#80BBCA","fontSize":"12px"}'>查看更多</span>
		    <span class="icon iconfont icon-gengduo1" :style='{"color":"#80BBCA","fontSize":"12px"}'></span>
		  </div>
		</div>
		<!-- 关于我们 -->

		<!-- 系统简介 -->
		<div id="system" class="animate__animated" :style='{"padding":"70px 10% 100px 30px","boxShadow":"0 1px 6px rgba(255, 255, 255, .3)","margin":"0 0 0","flexWrap":"wrap","background":"linear-gradient(180deg, #F0D1CF 0%, #FFD1CE 100%)","display":"flex","width":"50%","position":"relative","height":"auto","order":"6"}'>
		  <div :style='{"border":"1px solid rgb(191, 242, 255)","margin":"0 20px","color":"#000","textAlign":"center","borderWidth":"0 0 2px","width":"100%","lineHeight":"1.5","fontSize":"30px","fontWeight":"bold","order":"1","zIndex":"1"}'>{{systemIntroductionDetail.title}}</div>
		  <div :style='{"margin":"0 0 10px","color":"#999","textAlign":"center","display":"none","width":"100%","lineHeight":"1.5","fontSize":"20px"}'>{{systemIntroductionDetail.subtitle}}</div>
		  <div :style='{"border":"5px solid #BFF2FF","padding":"0 20px 20px","margin":"-380px 0 0","alignItems":"flex-end","borderRadius":"20px","background":"#fff","display":"flex","width":"100%","height":"520px","order":"3"}'>
		    <img :style='{"width":"calc(100% / 3 - 10px)","margin":"0 10px 0 0","objectFit":"cover","flex":1,"display":"block","height":"350px"}' :src="baseUrl + systemIntroductionDetail.picture1">
		    <img :style='{"width":"calc(100% / 3 -10px)","margin":"0 10px 0 0","objectFit":"cover","flex":1,"display":"block","height":"120px"}' :src="baseUrl + systemIntroductionDetail.picture2">
		    <img :style='{"width":"calc(100% / 3 -10px)","margin":"0","objectFit":"cover","flex":1,"display":"block","height":"120px"}' :src="baseUrl + systemIntroductionDetail.picture3">
		  </div>
		  <div :style='{"padding":"20px 10px 0","margin":"50px 0 50px auto","color":"#000","display":"-webkit-box","overflow":"hidden","width":"calc(200% / 3 - 10px)","lineHeight":"1.6","fontSize":"16px","textOverflow":"ellipsis","-webkit-box-orient":"vertical","-webkit-line-clamp":"7","order":"2","height":"200px","zIndex":"1"}' v-html="systemIntroductionDetail.content"></div>
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"width":"285px","background":"url(http://codegen.caihongy.cn/20201114/7856ba26477849ea828f481fa2773a95.jpg) 0% 0% / cover no-repeat","display":"none","height":"100px"}' />
		  <div :style='{"border":"1px solid rgb(128, 187, 202)","cursor":"pointer","margin":"10px auto","top":"65px","textAlign":"center","background":"none","display":"block","width":"100px","lineHeight":"30px","position":"absolute","right":"calc(20% + 20px)","zIndex":"999"}' @click="toDetail('systemintroDetail',systemIntroductionDetail)">
		    <span :style='{"color":"rgb(128, 187, 202)","fontSize":"12px"}'>查看更多</span>
		    <span class="icon iconfont icon-gengduo1" :style='{"color":"rgb(128, 187, 202)","fontSize":"12px"}'></span>
		  </div>
		</div>
		<!-- 系统简介 -->
		
	<!-- 新闻资讯 -->
	<div id="animate_newsnews" class="news animate__animated" :style='{"padding":"100px 10% 80px 10%","margin":"0 0 0","background":"url(http://codegen.caihongy.cn/20231217/9d455cda5ca74132a89d74e798694541.png)","width":"100%","backgroundPosition":"left center","position":"relative","backgroundRepeat":"no-repeat","order":"2"}'>
		<div v-if="false" class="idea newsIdea" :style='{"padding":"20px","flexWrap":"wrap","background":"#efefef","justifyContent":"space-between","display":"flex"}'>
			<div class="box1" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
			<div class="box2" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
			<div class="box3" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
			<div class="box4" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
			<div class="box5" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
			<div class="box6" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
			<div class="box7" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
			<div class="box8" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
			<div class="box9" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
			<div class="box10" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		</div>
		
		<div class="title" :style='{"border":"none","margin":"10px auto","textAlign":"center","background":"none","borderWidth":"0","width":"100%","lineHeight":"54px"}'>
			<span :style='{"border":"2px solid #BFF2FF","color":"#000","borderWidth":"0 0 2px","display":"inline-block","width":"calc(100% - 40px)","fontSize":"32px","fontWeight":"bold"}'>公告信息</span>
		</div>
		
			
			
			
			
			
			
			
			
			
			
		






		<div v-if="newsList.length" class="list list17 index-pv1" :style='{"border":"5px solid #BFF2FF","padding":"124px 20px 40px","margin":"-100px 0 0","borderRadius":"20px","background":"#fff","display":"flex","width":"100%","justifyContent":"space-between","height":"auto"}'>
		  <div class="swiper" :style='{"width":"45%","background":"#fff","height":"auto"}'>
		    <div class="swiper-container newsSwiper17 new-list-17news">
		      <div class="swiper-wrapper">
				<template v-for="(item,index) in newsList">
		        <div v-if="index < 3" class="swiper-slide">
		          <div :style='{"width":"100%","position":"relative","height":"auto"}' @click="toDetail('newsDetail', item)">
		            <img :style='{"width":"100%","objectFit":"cover","display":"block","height":"325px"}' :src="baseUrl + item.picture">
		            <div :style='{"alignItems":"center","left":"0","bottom":"0","background":"rgba(0,0,0,.3)","display":"flex","width":"100%","position":"absolute"}'>
		              <div :style='{"padding":"0 10px","lineHeight":"44px","fontSize":"18px","color":"#fff"}'>{{item.title}}</div>
		              <div :style='{"padding":"0 10px"}'>
		                <span class="icon iconfont icon-shijian21" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#fff"}'></span>
		                <span :style='{"color":"#fff","lineHeight":"1.5","fontSize":"12px"}'>{{item.addtime}}</span>
		              </div>
		            </div>
		          </div>
		        </div>
				</template>
		      </div>
		      <!-- Add Pagination -->
		      <div class="swiper-pagination" :style='{"width":"100%","left":"0","textAlign":"right","bottom":"10px"}'></div>
		    </div>
		  </div>
		  <div class="right" :style='{"width":"53%","height":"auto"}'>
		    <div v-if="newsList.length > 3" :style='{"border":"1px solid #50D9FF","padding":"10px","margin":"0 0 20px 0","flexWrap":"wrap","background":"#EDFBFF","display":"flex","width":"100%","height":"auto"}' @click="toDetail('newsDetail', newsList[3])">
		      <div :style='{"whiteSpace":"nowrap","overflow":"hidden","color":"#000","width":"100%","lineHeight":"30px","fontSize":"16px","textOverflow":"ellipsis","fontWeight":"bold","order":"1"}' class="name">{{newsList[3].title}}</div>
		      <div :style='{"whiteSpace":"nowrap","overflow":"hidden","color":"#4D4D4D","width":"100%","lineHeight":"28px","fontSize":"14px","textOverflow":"ellipsis","order":"2"}' class="desc">{{newsList[3].introduction}}</div>
		      <div :style='{"padding":"0","display":"inline-block","order":"7"}'>
		        <span class="icon iconfont icon-shijian21" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#4D4D4D"}'></span>
		        <span :style='{"color":"#4D4D4D","lineHeight":"1.5","fontSize":"12px"}'>{{newsList[3].addtime}}</span>
		      </div>
		      <div :style='{"padding":"0 10px 0 0","display":"inline-block","order":"6"}'>
		        <span class="icon iconfont icon-geren16" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#4D4D4D"}'></span>
		        <span :style='{"color":"#4D4D4D","lineHeight":"1.5","fontSize":"12px"}'>{{newsList[3].name}}</span>
		      </div>
		      <div :style='{"padding":"0 10px 0 0","display":"inline-block","order":"3"}'>
		        <span class="icon iconfont icon-zan10" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#4D4D4D"}'></span>
		        <span :style='{"color":"#4D4D4D","lineHeight":"1.5","fontSize":"12px"}'>{{newsList[3].thumbsupnum}}</span>
		      </div>
		      <div :style='{"padding":"0 10px 0 0","display":"inline-block","order":"4"}'>
		        <span class="icon iconfont icon-shoucang10" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#4D4D4D"}'></span>
		        <span :style='{"color":"#4D4D4D","lineHeight":"1.5","fontSize":"12px"}'>{{newsList[3].storeupnum}}</span>
		      </div>
		      <div :style='{"padding":"0 10px 0 0","display":"inline-block","order":"5"}'>
		        <span class="icon iconfont icon-chakan9" :style='{"margin":"0 2px 0 0","lineHeight":"1.5","fontSize":"12px","color":"#4D4D4D"}'></span>
		        <span :style='{"color":"#4D4D4D","lineHeight":"1.5","fontSize":"12px"}'>{{newsList[3].clicknum}}</span>
		      </div>
		    </div>
		    <div class="list" :style='{"border":"1px solid #50D9FF","width":"100%","padding":"10px","background":"#fff","height":"auto"}'>
			  <template v-for="(item,index) in newsList">
		      <div v-if="index > 3" :style='{"width":"100%","alignItems":"center","display":"flex","height":"auto"}' @click="toDetail('newsDetail', item)">
		        <div :style='{"width":"10px","margin":"0 10px","borderRadius":"100%","background":"#DF847F","height":"10px"}'></div>
		        <div class="title">{{item.title}}</div>
		        <div :style='{"padding":"0 6px"}'>
		          <span class="icon iconfont icon-shijian21" :style='{"color":"#909090","lineHeight":"44px","fontSize":"12px"}'></span>
		          <span :style='{"color":"#909090","lineHeight":"44px","fontSize":"12px"}'>{{item.addtime}}</span>
		        </div>
		      </div>
			  </template>
		    </div>
		  </div>
		</div>





		<div @click="moreBtn('news')" :style='{"border":"2px solid #80BBCA","cursor":"pointer","margin":"10px auto","top":"110px","textAlign":"center","background":"none","display":"block","width":"80px","lineHeight":"30px","position":"absolute","right":"calc(10% + 30px)"}'>
			<span :style='{"color":"#80BBCA","fontSize":"12px"}'>查看更多</span>
			<i :style='{"color":"#80BBCA","fontSize":"12px"}' class="icon iconfont icon-gengduo1"></i>
		</div>
		
		</div>
	<!-- 新闻资讯 -->


<!-- 商品推荐 -->
<div id="animate_recommendxianhuaxinxi" class="recommend animate__animated" :style='{"padding":"110px 10%","margin":"0","background":"url(http://codegen.caihongy.cn/20231228/66b2219633104669aa2b2ccc41d01f72.png)","width":"100%","backgroundSize":"cover","backgroundPosition":"center center","position":"relative","backgroundRepeat":"no-repeat","order":"4"}'>
	<div v-if="false" class="idea recommendIdea" :style='{"padding":"20px","flexWrap":"wrap","background":"#efefef","justifyContent":"space-between","display":"flex"}'>
		<div class="box1" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
		<div class="box2" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
		<div class="box3" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
		<div class="box4" :style='{"width":"20%","background":"#fff","height":"80px"}'></div>
		<div class="box5" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		<div class="box6" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		<div class="box7" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		<div class="box8" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		<div class="box9" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
		<div class="box10" :style='{"width":"20%","background":"#fff","display":"none","height":"80px"}'></div>
	</div>
	
    <div class="title" :style='{"width":"100%","margin":"10px auto","lineHeight":"54px","textAlign":"center","background":"none"}'>
		<span :style='{"border":"1px solid #BFF2FF","color":"#000","borderWidth":"0 0 2px","display":"inline-block","width":"calc(100% - 40px)","fontSize":"30px","fontWeight":"bold"}'>鲜花信息推荐</span>
	</div>
	
	
	
	
	
	
	
	
	
	





	<div v-if="xianhuaxinxiRecommend.length" class="list list14 index-pv1" :style='{"border":"5px solid #BFF2FF","padding":"120px 50px 50px","margin":"-90px 0 0","borderRadius":"20px","background":"#fff","display":"flex","width":"100%","justifyContent":"space-between","height":"auto"}'>
	  <div :style='{"width":"30%","position":"relative","height":"auto"}' class="left">
	    <img :style='{"width":"100% ","objectFit":"cover","display":"block","height":"535px"}' src="http://codegen.caihongy.cn/20230814/797fe92c8ce14417a09161c42381f9b3.jpg">
	    <template v-for="item,index in xianhuaxinxiRecommend">
		<template v-if="recommendIndex14xianhuaxinxi == index">
		<img @click="toDetail('xianhuaxinxiDetail', item)" :name="item.id" :style='{"objectFit":"cover","top":"70px","left":"96px","display":"block","width":"88% ","position":"absolute","height":"500px"}' v-if="preHttp(item.xianhuatupian)" :src="item.xianhuatupian.split(',')[0]" alt="" />
		<img @click="toDetail('xianhuaxinxiDetail', item)" :name="item.id" :style='{"objectFit":"cover","top":"70px","left":"96px","display":"block","width":"88% ","position":"absolute","height":"500px"}' v-else :src="baseUrl + (item.xianhuatupian?item.xianhuatupian.split(',')[0]:'')" alt="" />
		</template>
		</template>
	  </div>
	  <div :style='{"padding":"0","alignItems":"center","flexWrap":"wrap","display":"flex","width":"65%","justifyContent":"space-between","height":"auto"}' class="list">
	    <template v-for="item,index in xianhuaxinxiRecommend">
		<img @click="recommendClick14(index, 'xianhuaxinxi')" :name="item.id" :style='{"width":"31% ","objectFit":"cover","display":"block","height":"220px"}' v-if="preHttp(item.xianhuatupian)" :src="item.xianhuatupian.split(',')[0]" alt="" />
		<img @click="recommendClick14(index, 'xianhuaxinxi')" :name="item.id" :style='{"width":"31% ","objectFit":"cover","display":"block","height":"220px"}' v-else :src="baseUrl + (item.xianhuatupian?item.xianhuatupian.split(',')[0]:'')" alt="" />
		</template>
	  </div>
	</div>


	
	<div @click="moreBtn('xianhuaxinxi')" :style='{"border":"2px solid #80BBCA","margin":"10px auto","top":"120px","textAlign":"center","background":"none","display":"block","width":"80px","lineHeight":"30px","position":"absolute","right":"calc(10% + 20px)"}'>
		<span :style='{"color":"#80BBCA","fontSize":"12px"}'>查看更多</span>
		<i :style='{"color":"#80BBCA","fontSize":"12px"}' class="icon iconfont icon-gengduo1"></i>
	</div>
	
</div>
<!-- 商品推荐 -->

	
	<!-- 友链 -->
	<div id="friendly" class="friendly animate__animated" :style='{"padding":"100px 10% 80px  10%","margin":"0 auto","borderRadius":"0","background":"url(http://codegen.caihongy.cn/20231217/9d455cda5ca74132a89d74e798694541.png)","width":"100%","backgroundSize":"cover","backgroundPosition":"right center","backgroundRepeat":"no-repeat","height":"auto","order":"30"}'>
	  <div :style='{"borderColor":"#BFF2FF","margin":"10px auto","textAlign":"center","borderWidth":"0 0 2px","width":"100%","lineHeight":"54px","borderStyle":"solid","height":"auto"}'>
	    <div :style='{"padding":"0 10px","borderColor":"#BFF2FF","margin":"0","color":"#000","borderWidth":"0 0 2px","display":"inline-block","width":"calc(100% - 40px)","fontSize":"32px","borderStyle":"solid","fontWeight":"bold"}'>友情链接</div>
	  </div>
	  <div :style='{"border":"5px solid #BFF2FF","padding":"120px 20px 40px","margin":"-100px 0 0","borderRadius":"20px","alignItems":"flex-start","flexWrap":"wrap","background":"#fff","display":"flex","width":"100%","justifyContent":"space-between","height":"auto"}'>
	    <div :style='{"boxShadow":"0px 4px 10px 0px rgba(0,0,0,0.3)","padding":"20px","margin":"0 0 20px","alignItems":"center","borderRadius":"10px","flexDirection":"column","background":"#fff","display":"flex","width":"23%","justifyContent":"center","height":"auto"}' v-for="item in friendLinkList" :key="item.id" @click="friendlinkClick(item.url)">
	      <img :style='{"width":"100%","margin":"0 auto","objectFit":"cover","borderRadius":"4px","display":"block","height":"60px"}' :src="item.picture?(baseUrl + item.picture.split(',')[0]): ''" alt="">
	      <div :style='{"color":"#000","lineHeight":"30px","fontSize":"14px"}'>{{item.name}}</div>
	    </div>
	  </div>
	</div>
	<!-- 友链 -->
</div>
</template>

<script>
import 'animate.css'
import Swiper from "swiper";

  export default {
    //数据集合
    data() {
      return {
        baseUrl: '',
        aboutUsDetail: {},
        systemIntroductionDetail: {},
        queryList:[
          {
              queryName:"鲜花名称",
          },
        ],
        queryIndex: 0,
        xianhuaxinxixianhuamingcheng: '',
        newsList: [],
        xianhuaxinxiRecommend: [],


		newListSwiper17news: null,

		recommendIndex14xianhuaxinxi: 0,


		friendLinkList: [],
      }
    },
    created() {
		this.baseUrl = this.$config.baseUrl;
		this.getNewsList();
		this.getAboutUs();
		this.getSystemIntroduction();
		this.getList();
		this.getFriendLinkList()
    },
	mounted() {
		window.addEventListener('scroll', this.handleScroll)
		setTimeout(()=>{
			this.handleScroll()
		},100)
		
		this.swiperChanges()
	},
	beforeDestroy() {
	  window.removeEventListener('scroll', this.handleScroll)
	},
    //方法集合
    methods: {
		swiperChanges() {
			if (this['newListSwiper17news']) this['newListSwiper17news'].destroy()
			setTimeout(()=>{
				this['newListSwiper17news'] = new Swiper(".new-list-17news", {"pagination":{"el":".swiper-pagination","clickable":true}})
			},750)
		},
		// 获取友链列表
		getFriendLinkList(){
			this.$http.get('friendlink/list', {params:{page: 1,limit: 100}}).then(res => {
			  if(res.data.code == 0) {
			    this.friendLinkList = res.data.data.list
			  }
			})
		},
		// 友链跳转
		friendlinkClick(url){
			if(url){
				window.open(url)
			}
		},
		recommendClick14(index, name) {
			this['recommendIndex14' + name] = index
		},


		handleScroll() {
			let arr = [
				{id:'search',css:'animate__backInUp'},
				{id:'about',css:'animate__bounceInUp'},
				{id:'system',css:'animate__slideInDown'},
				{id:'animate_recommendxianhuaxinxi',css:'animate__rotateInUpRight'},
				{id:'animate_newsnews',css:'animate__heartBeat'},
				{id:'msgs',css:'animate__backInLeft'},
				{id:'friendly',css:'animate__fadeInBottomLeft'}
			]
			
			for (let i in arr) {
				let doc = document.getElementById(arr[i].id)
				if (doc) {
					let top = doc.offsetTop
					let win_top = window.innerHeight + window.pageYOffset
					// console.log(top,win_top)
					if (win_top > top && doc.classList.value.indexOf(arr[i].css) < 0) {
						// console.log(doc)
						doc.classList.add(arr[i].css)
					}
				}
			}
		},
      preHttp(str) {
          return str && str.substr(0,4)=='http';
      },
      getAboutUs() {
          this.$http.get('aboutus/detail/1', {}).then(res => {
            if(res.data.code == 0) {
              this.aboutUsDetail = res.data.data;
            }
          })
      },
      getSystemIntroduction() {
          this.$http.get('systemintro/detail/1', {}).then(res => {
            if(res.data.code == 0) {
              this.systemIntroductionDetail = res.data.data;
            }
          })
      },
      search(tablename) {
        if (this.queryIndex == 0 && this.xianhuaxinxixianhuamingcheng) {
          this.$router.push({path: '/index/' + tablename, query: {indexQueryCondition: this.xianhuaxinxixianhuamingcheng}});
        }
      },
		getNewsList() {
			let data = {
				page: 1,
				limit: 6,
                sort: 'addtime',
				order: 'desc'
			}
			this.$http.get('news/list', {params: data}).then(res => {
				if (res.data.code == 0) {
					this.newsList = res.data.data.list;
					
					
				}
			});
		},
		getList() {
			let autoSortUrl = "";
			let data = {}
          autoSortUrl = "xianhuaxinxi/autoSort";
          if(localStorage.getItem('frontToken')) {
              autoSortUrl = "xianhuaxinxi/autoSort2";
          }
			data = {
				page: 1,
				limit: 6,
			}
			this.$http.get(autoSortUrl, {params: data}).then(res => {
				if (res.data.code == 0) {
					this.xianhuaxinxiRecommend = res.data.data.list;
					
					
					// 商品列表样式五
					
				}
			});
			
		},
		toDetail(path, item) {
			this.$router.push({path: '/index/' + path, query: {id: item.id}});
		},
		moreBtn(path) {
			this.$router.push({path: '/index/' + path});
		}
    }
  }
</script>

<style rel="stylesheet/scss" lang="scss" scoped>
	.home-preview {
		// -------- search --------
		.search .select /deep/ .el-input__inner {
			border: 0;
			border-radius: 40px;
			padding: 0 30px 0 20px;
			box-shadow: none;
			outline: none;
			color: #000;
			width: 240px;
			font-size: 18px;
			height: 60px;
		}
		
		.search .input /deep/ .el-input__inner {
			border: 0;
			border-radius: 40px;
			padding: 0 20px;
			box-shadow: 0 0 6px rgba(64, 158, 255, .3);
			outline: none;
			color: #000;
			width: 600px;
			font-size: 18px;
			height: 60px;
		}
		// -------- search --------
		.recommend {
			.list3 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list3 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
			}
			
			.list3 .swiper-button-next {
				left: auto;
				right: 10px;
			}
			
			.list3 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.list5 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list5 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
        }
        
        .list5 .swiper-button-next {
				left: auto;
				right: 10px;
			}
			
			.list5 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.list5 {
				.swiper-slide-prev {
					position: relative;
					z-index: 3;
				}
		
				.swiper-slide-next {
					position: relative;
					z-index: 3;
				}
		
				.swiper-slide-active {
					position: relative;
					z-index: 5;
				}
			}
			
			.index-pv1 .animation-box {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				z-index: initial;
			}
			
			.index-pv1 .animation-box:hover {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 10px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
				z-index: 1;
			}
			
			.index-pv1 .animation-box img {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
			}
			
			.index-pv1 .animation-box img:hover {
				transform: rotate(0deg) scale(1.1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
			}
		}
		
		.news {
			.list3 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list3 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
			}
			
			.list3 .swiper-button-next {
				left: auto;
				right: 10px;
			}
			
			.list3 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.list6 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list6 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
			}
			
			.list6 .swiper-button-next {
				left: auto;
				right: 10px;
			}
			
			.list6 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.index-pv1 .animation-box {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				z-index: initial;
			}
			
			.index-pv1 .animation-box:hover {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 10px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
				z-index: 1;
			}
			
			.index-pv1 .animation-box img {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
			}
			
			.index-pv1 .animation-box img:hover {
				transform: rotate(0deg) scale(1.1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
			}
		}
	
		.lists {
			.list3 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list3 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
			}
			
			.list3 .swiper-button-next {
				left: auto;
				right: 10px;
        }
        
        .list3 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.list5 .swiper-button-prev {
				left: 10px;
				right: auto;
			}
			
			.list5 .swiper-button-prev::after {
				color: rgb(64, 158, 255);
			}
			
			.list5 .swiper-button-next {
            left: auto;
            right: 10px;
			}
			
			.list5 .swiper-button-next::after {
				color: rgb(64, 158, 255);
			}
			
			.list5 {
				.swiper-slide-prev {
					position: relative;
					z-index: 3;
				}
		
				.swiper-slide-next {
					position: relative;
					z-index: 3;
				}
		
				.swiper-slide-active {
					position: relative;
					z-index: 5;
				}
			}
			
			.index-pv1 .animation-box {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				z-index: initial;
			}
			
			.index-pv1 .animation-box:hover {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 10px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
				z-index: 1;
			}
			
			.index-pv1 .animation-box img {
				transform: rotate(0deg) scale(1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
			}
			
			.index-pv1 .animation-box img:hover {
				transform: rotate(0deg) scale(1.1) skew(0deg, 0deg) translate3d(0px, 0px, 0px);
				-webkit-perspective: 1000px;
				perspective: 1000px;
				transition: 0.3s;
			}
		}
	}
	



	.home-preview .news .list17 .newsSwiper17 .swiper-pagination /deep/ span.swiper-pagination-bullet {
				border-radius: 100%;
				margin: 0 4px;
				background: #fff;
				display: inline-block;
				width: 10px;
				opacity: .2;
				height: 10px;
			}
	
	.home-preview .news .list17 .newsSwiper17 .swiper-pagination /deep/ span.swiper-pagination-bullet:hover {
				background: #50D9FF;
				opacity: 1;
			}
	
	.home-preview .news .list17 .newsSwiper17 .swiper-pagination /deep/ span.swiper-pagination-bullet.swiper-pagination-bullet-active {
				background: #50D9FF;
				opacity: 1;
			}
	
	.home-preview .news .list17 .right .list .title {
				padding: 0 10px 0 0;
				overflow: hidden;
				color: #000;
				white-space: nowrap;
				flex: 1;
				font-weight: bold;
				font-size: 16px;
				line-height: 46px;
				text-overflow: ellipsis;
				transition: 0.3s;
			}
	
	.home-preview .news .list17 .right .list .title:hover {
				transform: translate3d(10px, 0px, 0px);
			}







</style>
