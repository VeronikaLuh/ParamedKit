import {Select} from "@/components/select/Select";

export const ItemInfo = () => {
  return (
    <div className='flex flex-col items-center w-full'>
      <div className='flex justify-between gap-11 w-full flex-wrap'>
        <input className='py-4 pl-[28px] rounded-lg text-[#695858] text-3xl' placeholder='Name'/>
        <Select styles={'py-3 px-4 text-[30px] rounded-2xl text-[#695858]'}>
          <option value="">Location</option>
        </Select>
        <Select styles={'py-3 px-4 text-[30px] rounded-2xl text-[#695858]'}>
          <option value="">Type of food</option>
        </Select>
        <Select styles={'py-3 px-4 text-[30px] rounded-2xl text-[#695858]'}>
          <option value="">Average cost</option>
        </Select>
      </div>
      <div className='pt-16 flex w-full'>
           <textarea
             id="admin-description"
             name="description"
             rows={5}
             cols={33}
             placeholder={'Description'}
             className='text-3xl text-[#695858] p-5 rounded-2xl w-full'
           />
        <div className='flex flex-col gap-11 pl-14 justify-center items-center'>
          <button className='px-9 text-2xl py-3 w-fit font-bold rounded-3xl bg-[#695858]'>Upload photo</button>
          <button className='px-9 text-2xl py-3 w-fit font-bold rounded-3xl bg-[#565656]'>Show photo</button>
          <div className='flex gap-11'>
            <button className='px-9 text-2xl py-3 font-bold rounded-3xl bg-[#738CE7]'>Reset</button>
            <button className='px-9 text-2xl py-3 font-bold rounded-3xl bg-[#59CD5D]'>Save</button>
          </div>
        </div>
      </div>
    </div>
  )
}