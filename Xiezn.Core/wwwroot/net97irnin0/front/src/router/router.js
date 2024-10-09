import VueRouter from 'vue-router'

//引入组件
import Index from '../pages'
import Home from '../pages/home/home'
import Login from '../pages/login/login'
import Register from '../pages/register/register'
import Center from '../pages/center/center'
import Storeup from '../pages/storeup/list'
import AddrList from '../pages/shop-address/list'
import AddrAdd from '../pages/shop-address/addOrUpdate'
import Order from '../pages/shop-order/list'
import OrderConfirm from '../pages/shop-order/confirm'
import Cart from '../pages/shop-cart/list'
import News from '../pages/news/news-list'
import NewsDetail from '../pages/news/news-detail'
import payList from '../pages/pay'

import yonghuList from '../pages/yonghu/list'
import yonghuDetail from '../pages/yonghu/detail'
import yonghuAdd from '../pages/yonghu/add'
import xianhuafenleiList from '../pages/xianhuafenlei/list'
import xianhuafenleiDetail from '../pages/xianhuafenlei/detail'
import xianhuafenleiAdd from '../pages/xianhuafenlei/add'
import xianhuaxinxiList from '../pages/xianhuaxinxi/list'
import xianhuaxinxiDetail from '../pages/xianhuaxinxi/detail'
import xianhuaxinxiAdd from '../pages/xianhuaxinxi/add'
import couponList from '../pages/coupon/list'
import couponDetail from '../pages/coupon/detail'
import couponAdd from '../pages/coupon/add'
import mycouponList from '../pages/mycoupon/list'
import mycouponDetail from '../pages/mycoupon/detail'
import mycouponAdd from '../pages/mycoupon/add'
import newstypeList from '../pages/newstype/list'
import newstypeDetail from '../pages/newstype/detail'
import newstypeAdd from '../pages/newstype/add'
import aboutusList from '../pages/aboutus/list'
import aboutusDetail from '../pages/aboutus/detail'
import aboutusAdd from '../pages/aboutus/add'
import systemintroList from '../pages/systemintro/list'
import systemintroDetail from '../pages/systemintro/detail'
import systemintroAdd from '../pages/systemintro/add'
import friendlinkList from '../pages/friendlink/list'
import friendlinkDetail from '../pages/friendlink/detail'
import friendlinkAdd from '../pages/friendlink/add'
import discussxianhuaxinxiList from '../pages/discussxianhuaxinxi/list'
import discussxianhuaxinxiDetail from '../pages/discussxianhuaxinxi/detail'
import discussxianhuaxinxiAdd from '../pages/discussxianhuaxinxi/add'

const originalPush = VueRouter.prototype.push
VueRouter.prototype.push = function push(location) {
	return originalPush.call(this, location).catch(err => err)
}

//配置路由
export default new VueRouter({
	routes:[
		{
      path: '/',
      redirect: '/index/home'
    },
		{
			path: '/index',
			component: Index,
			children:[
				{
					path: 'home',
					component: Home
				},
				{
					path: 'center',
					component: Center,
				},
				{
					path: 'pay',
					component: payList,
				},
				{
					path: 'storeup',
					component: Storeup
				},
                {
                    path: 'shop-address/list',
                    component: AddrList
                },
                {
                    path: 'shop-address/addOrUpdate',
                    component: AddrAdd
                },
				{
					path: 'shop-order/order',
					component: Order
				},
				{
					path: 'cart',
					component: Cart
				},
				{
					path: 'shop-order/orderConfirm',
					component: OrderConfirm
				},
				{
					path: 'news',
					component: News
				},
				{
					path: 'newsDetail',
					component: NewsDetail
				},
				{
					path: 'yonghu',
					component: yonghuList
				},
				{
					path: 'yonghuDetail',
					component: yonghuDetail
				},
				{
					path: 'yonghuAdd',
					component: yonghuAdd
				},
				{
					path: 'xianhuafenlei',
					component: xianhuafenleiList
				},
				{
					path: 'xianhuafenleiDetail',
					component: xianhuafenleiDetail
				},
				{
					path: 'xianhuafenleiAdd',
					component: xianhuafenleiAdd
				},
				{
					path: 'xianhuaxinxi',
					component: xianhuaxinxiList
				},
				{
					path: 'xianhuaxinxiDetail',
					component: xianhuaxinxiDetail
				},
				{
					path: 'xianhuaxinxiAdd',
					component: xianhuaxinxiAdd
				},
				{
					path: 'coupon',
					component: couponList
				},
				{
					path: 'couponDetail',
					component: couponDetail
				},
				{
					path: 'couponAdd',
					component: couponAdd
				},
				{
					path: 'mycoupon',
					component: mycouponList
				},
				{
					path: 'mycouponDetail',
					component: mycouponDetail
				},
				{
					path: 'mycouponAdd',
					component: mycouponAdd
				},
				{
					path: 'newstype',
					component: newstypeList
				},
				{
					path: 'newstypeDetail',
					component: newstypeDetail
				},
				{
					path: 'newstypeAdd',
					component: newstypeAdd
				},
				{
					path: 'aboutus',
					component: aboutusList
				},
				{
					path: 'aboutusDetail',
					component: aboutusDetail
				},
				{
					path: 'aboutusAdd',
					component: aboutusAdd
				},
				{
					path: 'systemintro',
					component: systemintroList
				},
				{
					path: 'systemintroDetail',
					component: systemintroDetail
				},
				{
					path: 'systemintroAdd',
					component: systemintroAdd
				},
				{
					path: 'friendlink',
					component: friendlinkList
				},
				{
					path: 'friendlinkDetail',
					component: friendlinkDetail
				},
				{
					path: 'friendlinkAdd',
					component: friendlinkAdd
				},
				{
					path: 'discussxianhuaxinxi',
					component: discussxianhuaxinxiList
				},
				{
					path: 'discussxianhuaxinxiDetail',
					component: discussxianhuaxinxiDetail
				},
				{
					path: 'discussxianhuaxinxiAdd',
					component: discussxianhuaxinxiAdd
				},
			]
		},
		{
			path: '/login',
			component: Login
		},
		{
			path: '/register',
			component: Register
		},
	]
})
