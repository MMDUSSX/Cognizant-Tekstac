function OrderCake(str) {
	matches = str.match(/\d+/g);
            var weight_in_gm = matches[0];
            var order_id = matches[1]

            var weight_notRound = Number(weight_in_gm/1000);
            var weight = Math.round(weight_notRound)
            var p = Number(weight_notRound*450);
            var price = Math.round(p)
            
            var first = str.split(weight_in_gm)

            var flavour = first[1].split(matches[1])[0]

            var newStr = "Your order for "+ weight + " kg "+ flavour + " cake has been taken. You are requested to pay Rs. "+price+
                        " on the order no "+ order_id+ ""
            return newStr
}