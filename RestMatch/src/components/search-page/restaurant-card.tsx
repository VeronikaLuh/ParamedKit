import { imageUrl } from "@/utils/constants";
import React from "react";

interface RestaurantCardProps {
  url?: string;
  name: string;
  city: string;
  price: number;
  description: string;
}

const RestaurantCard: React.FC<RestaurantCardProps> = ({url, name, city, description, price}) => {
  return (
    <div className="bg-[#8d6539] rounded-[10px] flex items-center justify-between mb-14 px-[31px] pt-[34px] pb-[24px] gap-4 drop-shadow-2xl min-w-[55.9rem]">
      <img
        className="rounded-lg w-[316px] h-[239px]"
        src={`${imageUrl}/searchpage/restourant-icon.jpg`}
        alt="Description of image"
      />
      <div className="flex flex-col self-start gap-1 text-white max-h-[239px]">
        <h3 className="leading-none text-[36px] font-normal">
          {name}
        </h3>
        <h3 className="text-[32px]">{city} • {price} ₴ • Italic</h3>
        <p className="text-[20px] overflow-hidden">
          {description}
        </p>
      </div>
      <div>
        <button className="px-14 py-2 text-[25px] text-nowrap rounded-[30px] bg-[#CF914E] text-white font-bold">
          VIEW MORE
        </button>
      </div>
    </div>
  );
};

export default RestaurantCard;
