import {imageUrl} from "@/utils/constants";
import Collapsible from "@/components/common/Collapsible";
import {ItemInfo} from "@/components/admin/ItemInfo";
import {useState} from 'react';

export const ProductEdit = () => {
  const [active, setActive] = useState(false);

  const handleEdit = () => {
    setActive(!active);
  }

  return (
    <div className='mb-12'>
      <div
        className="bg-[#8d6539] rounded-[10px] flex items-center justify-between px-[31px] pt-[34px] pb-[24px] gap-4 drop-shadow-2xl">
        <img
          className="rounded-lg w-[316px] h-[239px]"
          src={`${imageUrl}/searchpage/restourant-icon.jpg`}
          alt="Description of image"
        />
        <div className="flex flex-col self-start text-white max-h-[239px]">
          <h3 className="leading-none text-[36px] font-normal">
            Biblioteka resto•bar
          </h3>
          <h3 className="text-[32px]">Lviv • 150 ₴ • Italic</h3>
          <p className="text-[20px]  overflow-hidden">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget
            faucibus tortor. Vivamus blandit eros in enim mollis, vel lobortis
            neque eleifend. Sed a consectetur tellus, ut sodales nibh. Lorem ipsum
            dolor sit amet, consectetur adipiscing elit. Nullam ut nulla urna.
            Aliquam dolor nisl, convallis sit amet diam ut, tempor euismod massa.
            Etiam commodo placerat libero, ut placerat elit sagittis vel.
          </p>
        </div>
        <div className='flex flex-col gap-7'>
          <button onClick={handleEdit}
                  className="px-14 py-2 text-xl text-nowrap rounded-[30px] bg-[#CF914E] text-white font-bold w-full">
            Edit info
          </button>
          <button className="px-14 py-2 text-xl text-nowrap rounded-[30px] bg-[#A10005] text-white font-bold w-full">
            Delete
          </button>
        </div>
      </div>
      <Collapsible toggle={active}>
        <div className='ml-2 bg-[#775a3a] py-7 px-6 shadow-inner'>
          <ItemInfo />
        </div>
      </Collapsible>
    </div>
  );
}