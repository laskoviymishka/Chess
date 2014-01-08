
// DO NOT REFERENCE THIS FILE IN PRODUCTION CODE
// This should be used solely to generate intellisense in visual studio







(function($) {
	"use strict";

	if (!$) {
		throw "jQuery is required";
	}

	$.proxies = $.proxies || {};

	function getQueryString(params, queryString) {
		queryString = queryString || "";
		for(var prop in params) {
			if (params.hasOwnProperty(prop)) {
				var val = getArgValue(params[prop]);
				if (val === null) continue;

				if ("" + val === "[object Object]") {
					queryString = getQueryString(params[prop], queryString);
					continue;
				}

				if (queryString.length) {
					queryString += "&";
				} else {
					queryString += "?";
				}
				queryString = queryString + prop + "=" +val;
			}
		}
		return queryString;
	}

	function getArgValue(val) {
		if (val === undefined || val === null) return null;
		return val;
	}

	function invoke(url, type, urlParams, body) {
		url += getQueryString(urlParams);


		var ajaxOptions = $.extend({}, this.defaultOptions, {
			url: url,
			type: type
		});

		if (body) {
			ajaxOptions.data = body;
		}

		if (this.antiForgeryToken) {
			var token = $.isFunction(this.antiForgeryToken) ? this.antiForgeryToken() : this.antiForgeryToken;
			if (token) {
				ajaxOptions.headers = ajaxOptions.headers || {};
				ajaxOptions.headers["X-RequestVerificationToken"] = token
			}
		}
	
		return $.ajax(ajaxOptions);
	};

	function defaultAntiForgeryTokenAccessor() {
		return $("input[name=__RequestVerificationToken]").val();
	};

	/* Proxies */

	
	$.proxies.account = {
		defaultOptions: {},
		antiForgeryToken: defaultAntiForgeryTokenAccessor,



	login: function(model,returnUrl) {
		return invoke.call(this, "", "post", 
		
			{
			
				model: arguments[0],
			
				returnUrl: arguments[1],
			
			}
		
		
			);
		
	},



	logoff: function() {
		return invoke.call(this, "", "post", 
		
			{}
		
		
			);
		
	},



	register: function(model) {
		return invoke.call(this, "", "post", 
		
			{}
		
		
			, arguments[0]);
		
	},



	disassociate: function(provider,providerUserId) {
		return invoke.call(this, "", "post", 
		
			{
			
				provider: arguments[0],
			
				providerUserId: arguments[1],
			
			}
		
		
			);
		
	},



	manage: function(message) {
		return invoke.call(this, "", "get", 
		
			{
			
				message: arguments[0],
			
			}
		
		
			);
		
	},



	externallogin: function(provider,returnUrl) {
		return invoke.call(this, "", "post", 
		
			{
			
				provider: arguments[0],
			
				returnUrl: arguments[1],
			
			}
		
		
			);
		
	},



	externallogincallback: function(returnUrl) {
		return invoke.call(this, "", "get", 
		
			{
			
				returnUrl: arguments[0],
			
			}
		
		
			);
		
	},



	externalloginconfirmation: function(model,returnUrl) {
		return invoke.call(this, "", "post", 
		
			{
			
				model: arguments[0],
			
				returnUrl: arguments[1],
			
			}
		
		
			);
		
	},



	externalloginfailure: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},



	externalloginslist: function(returnUrl) {
		return invoke.call(this, "", "get", 
		
			{
			
				returnUrl: arguments[0],
			
			}
		
		
			);
		
	},



	removeexternallogins: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},

};
	
	$.proxies.home = {
		defaultOptions: {},
		antiForgeryToken: defaultAntiForgeryTokenAccessor,



	index: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},



	about: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},



	contact: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},

};
	
	$.proxies.testapi = {
		defaultOptions: {},
		antiForgeryToken: defaultAntiForgeryTokenAccessor,



	index: function() {
		return invoke.call(this, "", "get", 
		
			{}
		
		
			);
		
	},



	details: function(id) {
		return invoke.call(this, "", "get", 
		
			{
			
				id: arguments[0],
			
			}
		
		
			);
		
	},



	create: function(collection) {
		return invoke.call(this, "", "post", 
		
			{}
		
		
			, arguments[0]);
		
	},



	edit: function(id,collection) {
		return invoke.call(this, "", "post", 
		
			{
			
				id: arguments[0],
			
				collection: arguments[1],
			
			}
		
		
			);
		
	},



	delete: function(id,collection) {
		return invoke.call(this, "", "post", 
		
			{
			
				id: arguments[0],
			
				collection: arguments[1],
			
			}
		
		
			);
		
	},

};
	
}(jQuery));