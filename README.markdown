# SuperLoad jQuery Plugin


This plugin adds the ability to update multiple elements with a single Ajax response.


## Usage


	$.superLoad( options );
The options are the same as taken by the jQuery.ajax( ) method, with the following observations:                   
* dataType: defaults to 'html'                                                                                  
* success: will be called after the content is updated on the page.                                             
                                                                                                                   
Expected response format:                                                                                          
	<div class="ajax-response">                                                                                       
															   
		<div class="ajax-content" title="!update #div1">                                                              
			<p>                                                                                                       
				Anything inside this div will be used to update the #div1 element                                     
				like $('#div1').html( $(thisDiv).html() );                                                            
			</p>                                                                                                      
		</div>                                                                                                        
															   
		<div class="ajax-content" title="!appendTo #div2">                                                            
			<p>                                                                                                       
				Anything inside this div will be appended to the #div2 element                                        
				like $('#div2').append( $(thisDiv).html() );                                                          
			</p>                                                                                                      
		</div>                                                                                                        
															   
		<div class="ajax-content" title="!prependTo #div3">                                                           
			<p>                                                                                                       
				Anything inside this div will be prepended to the #div3 element                                       
				like $('#div3').prepend( $(thisDiv).html() );                                                         
			</p>                                                                                                      
		</div>                                                                                                        
															   
		<div class="ajax-content" title="#div4">                                                                      
			<p>                                                                                                       
				if the !command is not given, !update will be assumed                                                 
			</p>                                                                                                      
		</div>                                                                                                        
															   
		<div class="ajax-content" title="!replaceWith #div5">                                                         
			<p>                                                                                                       
				Replaces #div5 with this P element                                                                    
			</p>                                                                                                      
		</div>                                                                                                        
															   
		<script>                                                                                                      
			//each script tag will be evaluated after the content has been applied.                                   
			doStuff();                                                                                                
		</script>                                                                                                     
															   
		<script>                                                                                                      
			doOtherStuff();                                                                                           
		</script>                                                                                                     
															   
	</div>                                                                                                            

The title attribute:

* The ajax-content element's title attribute is used to determine what to do with the content:
* The format is: "!command selector"
* "!command": defaults to !update
* !update:	replaces the inner HTML of the selected element(s) with the inner HTML of the ajax-content
* !prependTo:	adds the inner HTML of the ajax-content to the top of the inner HTML of the selected element(s)
* !appendTo:	adds the inner HTML of the ajax-content to the bottom of the inner HTML of the selected element(s)
* !other:		Beyond the above 3 standard !commands, one can also simply pass 
the name of any valid jQuery command (default of from a plugin) as
long as the command is able to be applied to the selected element(s)
and takes the new content as its argument.


## LICENSE:

Dual licensed under the MIT and GPL licenses:
*   http://www.opensource.org/licenses/mit-license.php
*   http://www.gnu.org/licenses/gpl.html
