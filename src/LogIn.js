import {React} from 'react';


 export default function LogIn(){

        return (
     
            <>
          

<div class="account-wrapper register">
<h3 class="account-title">Log In</h3>


<form action="admin-dashboard.html">
<div class="form-group">
<label>Email<span class="mandatory">*</span></label>
<input class="form-control" type="text"/>
</div>
<div class="form-group">
<label>Password<span class="mandatory">*</span></label>
<input class="form-control" type="password"/>
</div>
<div class="account-footer">
<p>Access to Library dashboard? <input type="checkbox" /></p>
</div>


<div class="form-group text-center">
<button class="btn btn-primary account-btn" type="submit" ><a href='./Singin'>Log In</a></button>
</div>
</form>

</div>    </>
        )
}





